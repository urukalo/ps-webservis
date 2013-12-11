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
                  'naziv'=>$object->getNaziv()
        ); 
        
        if(null===($idStanica=$object->getId())){
            unset($data['idStanica']);
            $this->getDbTable()->insert($data);
        }else{
            $this->getDbTable()->update($data,array('idStanica=?'=>$idStanica));
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
}

