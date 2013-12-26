<?php

class Application_Model_TrasastanicaMapper {

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
            $this->setDbTable('Application_Model_DbTable_Trasastanica');
        }
        return $this->_dbTable;
    }

    public function save(Application_Model_Trasastanica $object) {
        $data = array(
            'idTrasaStanica' => $object->getId(),
            'idTrasa' => $object->getTrasa(),
            'idStanica' => $object->getStanica(),
            'kmOd' => $object->getKmOd(),
            'kmDo' => $object->getKmDo()
        );

        if (null === ($idTrasaStanica = $object->getId())) {
            unset($data['idTrasaStanica']);
            $this->getDbTable()->insert($data);
        } else {
            $this->getDbTable()->update($data, array('idTrasaStanica=?' => $idTrasaStanica));
        }
    }

    public function dohvatiSve() {
        $resultSet = $this->getDbTable()->fetchAll('true');
        $Items = array();
        foreach ($resultSet as $row) {
            $object = new Application_Model_Trasastanica();
            $object->setId($row->idTrasaStanica)->setTrasa($row->idTrasa)->setStanica($row->idStanica)->setKmOd($row->kmOd)->setKmDo($row->kmDo);
            $Items[] = $object;
        }
        return $Items;
    }

    public function dohvatiSveAdmin() {
        $statement = "SELECT * FROM stanica s INNER JOIN trasastanica ts ON s.idStanica = ts.idStanica INNER JOIN trasa t ON ts.idTrasa = t.idTrasa";
        $db = Zend_Db_Table::getDefaultAdapter();
        $resultSet = $db->query($statement)->fetchAll();
        $Items = "";
        foreach ($resultSet as $row) {
            $object = $row['ime'] . " " . $row['polazak'] . "-" . $row['dolazak'] . "_" . $row['idTrasaStanica'] . "_" . $row['ime'] . "_" . $row['kmOd'] . "_" . $row['kmDo'];
            $Items.=$object . "#";
        }
        return $Items;
    }

    public function dohvatiJedan($id) {
        $resultSet = $this->getDbTable()->fetchAll("idTrasaStanica=$id");
        $Item = array();
        foreach ($resultSet as $row) {
            $object = new Application_Model_Trasastanica();
            $object->setId($row->idTrasaStanica)->setTrasa($row->idTrasa)->setStanica($row->idStanica)->setKmOd($row->kmOd)->setKmDo($row->kmDo);
            $Item[] = $object;
        }
        return $Item;
    }

    public function dohvatiJedanAdmin($id) {
        $statement = "SELECT * FROM stanica s INNER JOIN trasastanica ts ON s.idStanica = ts.idStanica INNER JOIN trasa t ON ts.idTrasa = t.idTrasa WHERE ts.idTrasaStanica=$id";
        $db = Zend_Db_Table::getDefaultAdapter();
        $resultSet = $db->query($statement)->fetchAll();
        $Items = "";
        foreach ($resultSet as $row) {
            $object = $row['ime'] . "@" . $row['polazak'] . "-" . $row['dolazak'] . "_" . $row['idTrasaStanica'] . "_" . $row['ime'] . "_" . $row['kmOd'] . "_" . $row['kmDo'] . "_" . $row['idTrasa'] . "_" . $row['idStanica'];
            return $object;
        }
    }

    public function dohvatiSveNaTrasi($id) {
        $statement = "SELECT * FROM stanica s INNER JOIN trasastanica ts ON s.idStanica = ts.idStanica INNER JOIN trasa t ON ts.idTrasa = t.idTrasa WHERE ts.idTrasa=$id";

        $db = Zend_Db_Table::getDefaultAdapter();

        $resultSet = $db->query($statement)->fetchAll();
        //throw new Ekarta_Exception(print_r($resultSet, true));
        $Item = array();
        foreach ($resultSet as $row) {
            $object = new Application_Model_Stanica();
            $object->setId($row['idStanica'])->setNaziv($row['ime']);
            $Item[] = $object;
        }
        //throw new Ekarta_Exception(print_r($Item, true));
        return $Item;
    }

    public function dohvatiIdTrase($idStanice) {
        $resultSet = $this->getDbTable()->fetchAll("idStanica=$idStanice");

        return $resultSet;
    }

    public function delete($id) {
        $this->getDbTable()->delete("idTrasa=$id");
    }

}
