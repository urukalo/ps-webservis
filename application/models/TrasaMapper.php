<?php

class Application_Model_TrasaMapper
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
            $this->setDbTable('Application_Model_DbTable_Trasa');
        }
        return $this->_dbTable;
    }
    public function save(Application_Model_Trasa $object){
        $data=array(
                  'idTrasa'=>$object->getId(),
                  'idStanicaPolaska'=>$object->getStanicaPolaska(),
                  'idStanicaDolaska'=>$object->getStanicaDolaska(),
                  'ukupnoKm'=>$object->getUkupnoKm()
        ); 
        
        if(null===($idTrasa=$object->getId())){
            unset($data['idTrasa']);
            $this->getDbTable()->insert($data);
        }else{
            $this->getDbTable()->update($data,array('idTrasa=?'=>$idTrasa));
        }
    }
    public function dohvatiSve(){
        $resultSet=$this->getDbTable()->fetchAll('true');
        $Items=array();
        foreach ($resultSet as $row){
            $object=new Application_Model_Trasa();
            $object->setId($row->idTrasa)->setStanicaPolaska($row->idStanicaPolaska)->setStanicaDolaska($row->idStanicaDolaska)->getUkupnoKm($row->ukupnoKm);
            $Items[]=$object;
        }
        return $Items;
    }
    public function dohvatiJedan($id){
        $resultSet=$this->getDbTable()->fetchAll("idTrasa=$id");
        $Item=array();
        foreach ($resultSet as $row){
            $object=new Application_Model_Trasa();
            $object->setId($row->idTrasa)->setStanicaPolaska($row->idStanicaPolaska)->setStanicaDolaska($row->idStanicaDolaska)->getUkupnoKm($row->ukupnoKm);
            $Item[]=$object;
        }
        return $Item;
    }
    public function delete($id){
        $this->getDbTable()->delete("idTrasa=$id");
    }
}

