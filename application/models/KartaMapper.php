<?php

class Application_Model_KartaMapper {

    protected $_dbTable;

    public function setDbTable($dbTable) {
        if (is_string($dbTable)) {
            $dbTable = new $dbTable();
        }
        if (!$dbTable instanceof Zend_Db_Table_Abstract) {
            throw new Exception("Unknown table geteway");
        }
        $this->_dbTable = $dbTable;
        return $this;
    }

    public function getDbTable() {
        if (null == $this->_dbTable) {
            $this->setDbTable('Application_Model_DbTable_Karta');
        }
        return $this->_dbTable;
    }

    public function save(Application_Model_Karta $object) {
        $data = array(
            'idKarta' => $object->getId(),
            'idTrasa' => $object->getTrasa(),
            'idPopust' => $object->getPopust(),
            'idStanicaPolaska' => $object->getStanicaPolaska(),
            'idStanicaDolaska' => $object->getStanicaDolaska(),
            'vremePolaska' => $object->getVremePolaska(),
            'povratna' => $object->getPovratna(),
            'cena' => $object->getCena(),
            'aktivnost' => $object->getAktivnost(),
            'idPopust' => $object->getPopust(),
            'aktivnost' => $object->getAktivnost(),
            'povratna' => $object->getPovratna()
        );

        if (null === ($idKarta = $object->getId())) {
            unset($data['idKarta']);
            $this->getDbTable()->insert($data);
            return "insert";
        } else {
            $this->getDbTable()->update($data, array('idKarta=?' => $idKarta));
            return "update";
        }
    }

    public function dohvatiSve() {
        $resultSet = $this->getDbTable()->fetchAll('true');
        $Items = array();
        foreach ($resultSet as $row) {
            $object = new Application_Model_Karta();
            $object->setId($row->idKarta)->setTrasa($row->idTrase)->setStanicaPolaska($row->idStanicaPolaska)->setStanicaDolaska($row->idStanicaDolaska)->setVremePolaska($row->vremePolaska)->setCena($row->cena)->setAktivnost($row->aktivnost);
            $Items[] = $object;
        }
        return $Items;
    }

    public function dohvatiJedan($id) {
        $db = Zend_Db_Table::getDefaultAdapter();
        $resultSet = $db->query("SELECT s.ime FROM karta k INNEr JOIN stanica s ON k.idStanicaPolaska= s.idStanica WHERE k.idKarta=$id;");
        foreach ($resultSet as $row) {
            $polaznaStanica=$row['ime'];
        }
        $resultSet1 = $db->query("SELECT * "
                . "FROM karta k "
                . "INNER JOIN trasa t ON k.idTrasa=t.idTrasa "
                . "LEFT OUTER JOIN popusti p ON k.idPopust=p.idPopust "
                . "INNER JOIN stanica s ON k.idStanicaDolaska=s.idStanica "
                . "WHERE k.idKarta=$id;");
        foreach ($resultSet1 as $row) {
            $row['nazsiv']===NULL?$popust="Nema popusta":$popust=$row['nazsiv'];
            $ostatak=$row['ime']."_".$row['polazak']." - ".$row['dolazak']."_".date("d.m.Y H:i",$row['vremePolaska'])."_".$row['cena']."_".$popust."_".$row['aktivnost']."_".$row['povratna'];
        }
        return $polaznaStanica."_".$ostatak;
    }

    public function deaktiviraj($id) {
        $statement = "UPDATE karta SET aktivnost=0 WHERE idKarta=$id";
        $db = Zend_Db_Table::getDefaultAdapter();
        $resultSet = $db->query($statement);
    }
    public function aktiviraj($id) {
        $statement = "UPDATE karta SET aktivnost=1 WHERE idKarta=$id";
        $db = Zend_Db_Table::getDefaultAdapter();
        $resultSet = $db->query($statement);
    }

    public function izracunajCenu($idTrasa,$idPolazneStanice,$idDolazneStanice,$idPopust,$povratna){
        $db = Zend_Db_Table::getDefaultAdapter();
        $resultSet = $db->query("SELECT kmOd FROM trasastanica WHERE idStanica=$idPolazneStanice AND idTrasa=$idTrasa");
        foreach ($resultSet as $row) {
            $kmOdPolazak = $row['kmOd'];
        }
        $resultSet1 = $db->query("SELECT kmOd FROM trasastanica WHERE idStanica=$idDolazneStanice AND idTrasa=$idTrasa");
        foreach ($resultSet1 as $row) {
            $kmOdDolazak = $row['kmOd'];
        }
        $popust=0;
        if($idPopust!=0){
            $resultSet = $db->query("SELECT procenat FROM popusti WHERE idPopust=$idPopust");
            foreach ($resultSet as $row) {
                $popust = $row['procenat'];
            }
        }
        $povratna===1?$povratna=15:$povratna=0;
        return (($kmOdDolazak-$kmOdPolazak)*1.8*(100-$popust)/100)*(100-$povratna)/100;
    }
    
    public function delete($id) {
        $this->getDbTable()->delete("idKarta=$id");
    }

}
