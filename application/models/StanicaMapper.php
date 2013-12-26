<?php

class Application_Model_StanicaMapper
{
    protected $_dbTable;
 
    public function setDbTable($dbTable){
        if(is_string($dbTable)){
            $dbTable=new $dbTable();
        }
        if(!$dbTable instanceof Zend_Db_Table_Abstract){
            throw new Exception("Unknown table geteway");
        }
        $this->_dbTable=$dbTable;
        return $this;
    }
    public function getDbTable(){
        if (null == $this->_dbTable) {
            $this->setDbTable('Application_Model_DbTable_Stanica');
        }
        return $this->_dbTable;
    }
    public function save(Application_Model_Stanica $object){
        $data=array(
                  'idStanica'=>$object->getId(),
                  'ime'=>$object->getNaziv()
        ); 
        if(null===($idStanica=$object->getId())){
            unset($data['idStanica']);
            return $this->getDbTable()->insert($data);
        }else{
            $this->getDbTable()->update($data,array('idStanica=?'=>$idStanica));
            return $idStanica;
        }
    }
    public function dohvatiSve(){
        $resultSet=$this->getDbTable()->fetchAll('true');
        $Items=array();
        foreach ($resultSet as $row){
            $object=new Application_Model_Stanica();
            $object->setId($row->idStanica)->setNaziv($row->ime);
            $Items[]=$object;
        }
        return $Items;
    }
    public function dohvatiSveAdmin(){
        $statement = "SELECT * FROM stanica GROUP BY ime";
        $db = Zend_Db_Table::getDefaultAdapter();
        $resultSet = $db->query($statement);
        $Items="";
        foreach ($resultSet as $row){
            $object=$row['idStanica']."_".$row['ime'];
            $Items.=$object."#";
        }
        return $Items;
    }
    public function dohvatiJedan($id){
        $resultSet=$this->getDbTable()->fetchAll("idStanica=$id");
        $Item=array();
        foreach ($resultSet as $row){
            $object=new Application_Model_Stanica();
            $object->setId($row->idStanica)->setNaziv($row->naziv);
            $Item[]=$object;
        }
        return $Item;
    }
    public function delete($id){
        $this->getDbTable()->delete("idStanica=$id");
    }
    public function dohvatiPocetne($idTrasa) {
        $statement = "SELECT * FROM stanica s INNER JOIN trasastanica ts ON s.idStanica=ts.idStanica WHERE idTrasa=$idTrasa AND ts.kmOd=0;";
        $db = Zend_Db_Table::getDefaultAdapter();
        $resultSet = $db->query($statement);
        $Items=array();
        foreach ($resultSet as $row){
            $object=new Application_Model_Stanica();
            $object->setId($row->idStanica)->setNaziv($row->ime);
            $Items[]=$object;
        }
        return $Items;
    }
    public function dohvatiKrajnje($idTrasa) {
        $statement = "SELECT * FROM stanica s INNER JOIN trasastanica ts ON s.idStanica=ts.idStanica WHERE idTrasa=$idTrasa AND ts.kmDo=0;";
        $db = Zend_Db_Table::getDefaultAdapter();
        $resultSet = $db->query($statement);
        $Items=array();
        foreach ($resultSet as $row){
            $object=new Application_Model_Stanica();
            $object->setId($row->idStanica)->setNaziv($row->ime);
            $Items[]=$object;
        }
        return $Items;
    }
}

