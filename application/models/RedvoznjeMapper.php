<?php

class Application_Model_RedvoznjeMapper {

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
            $this->setDbTable('Application_Model_DbTable_Redvoznje');
        }
        return $this->_dbTable;
    }

    public function save(Application_Model_Redvoznje $object) {
        $data = array(
            'idRedVoznje' => $object->getId(),
            'idTrasa' => $object->getTrasa(),
            'dan' => $object->getDan(),
            'vremePolaska' => $object->getVremePolaska()
        );

        if (null === ($idRedVoznje = $object->getId())) {
            unset($data['idRedVoznje']);
            $this->getDbTable()->insert($data);
        } else {
            $this->getDbTable()->update($data, array('idRedVoznje=?' => $idRedVoznje));
        }
    }

    public function dohvatiSve() {
        $resultSet = $this->getDbTable()->fetchAll('true');
        $Items = array();
        foreach ($resultSet as $row) {
            $object = new Application_Model_Redvoznje();
            $object->setId($row->idRedVoznje)->setTrasa($row->idTrasa)->setDan($row->dan)->setVremePolaska($row->vremePolaska);
            $Items[] = $object;
        }
        return $Items;
    }

    public function dohvatiSveAdmin() {
        $statement = "SELECT rv.idRedVoznje,rv.dan,rv.vremePolaska,rv.idTrasa,t.polazak,t.dolazak,t.ukupnoKm FROM redvoznje rv INNER JOIN  trasa t ON rv.idTrasa=t.idTrasa";
        $db = Zend_Db_Table::getDefaultAdapter();
        $resultSet = $db->query($statement);
        $Items = "";
        foreach ($resultSet as $row) {
            $object = $row['idRedVoznje'] . "_" . $row['idTrasa'] . "_" . $row['dan'] . "_" . $row['vremePolaska'] . "_" . $row['polazak'] . "-" . $row['dolazak'];
            $Items.=$object . "#";
        }
        return $Items;
    }

    public function dohvatiJedan($id) {
        $resultSet = $this->getDbTable()->fetchAll("idRedVoznje=$id");
        $Item = array();
        foreach ($resultSet as $row) {
            $object = new Application_Model_Redvoznje();
            $object->setId($row->idRedVoznje)->setTrasa($row->idTrasa)->setDan($row->dan)->setVremePolaska($row->vremePolaska);
            $Item[] = $object;
        }
        return $Item;
    }

    public function dohvatiJedanAdmin($id) {
        $resultSet = $this->getDbTable()->fetchAll("idRedVoznje=$id");
        $Item = "";
        foreach ($resultSet as $row) {
            $object = new Application_Model_Redvoznje();
            $object = $row->idRedVoznje . "_" . $row->idTrasa . "_" . $row->dan . "_" . $row->vremePolaska;
            return $object;
        }
    }

    public function dajVoznjeNaTrasi($idTrase, $dan) {
        $resultSet = $this->getDbTable()->fetchAll("idTrasa='$idTrase' AND dan = '$dan'");
//throw new Ekarta_Exception(print_r( $resultSet, true));
        $Item = array();
        foreach ($resultSet as $row) {

            $object = new Application_Model_Redvoznje();
            $object->setId($row->idRedVoznje)->setTrasa($row->idTrasa)->setDan($row->dan)->setVremePolaska($row->vremePolaska);
            $Item[] = $object;
        }
//throw new Ekarta_Exception(print_r( $Item, true));
        return $Item;
    }

    public function dohvatiZaStanice() {
        
    }

    public function proveriDaLiPostoji($idTrase, $dan, $vreme) {
        $statement = "SELECT * FROM redvoznje WHERE idTrase=$idTrase AND dan=$dan AND vreme='$vreme';";
        $db = Zend_Db_Table::getDefaultAdapter();
        $resultSet = $db->query($statement);
        if (count($resultSet) == 1) {
            return true;
        }
        return false;
    }

    public function delete($id) {
        $this->getDbTable()->delete("idRedVoznje=$id");
    }

}
