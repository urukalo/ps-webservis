<?php

class Application_Model_KartaMapper
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
            $this->setDbTable('Application_Model_DbTable_Karta');
        }
        return $this->_dbTable;
    }
    public function save(Application_Model_Karta $object){
        $data=array(
                  'idKarta'=>$object->getId(),
                  'idTrase'=>$object->getTrasa(),
                  'idStanicaPolaska'=>$object->getStanicaPolaska(),
                  'idStanicaDolaska'=>$object->getStanicaDolaska(),
                  'vremePolaska'=>$object->getVremePolaska(),
                  'cena'=>$object->getCena(),
                  'aktivnost'=>$object->getAktivnost()
        ); 
        
        if(null===($idKarta=$object->getId())){
            unset($data['idKarta']);
            $this->getDbTable()->insert($data);
        }else{
            $this->getDbTable()->update($data,array('idKarta=?'=>$idKarta));
        }
    }
    public function dohvatiSve(){
        $resultSet=$this->getDbTable()->fetchAll('true');
        $Items=array();
        foreach ($resultSet as $row){
            $object=new Application_Model_Karta();
            $object->setId($row->idKarta)->setTrasa($row->idTrase)->setStanicaPolaska($row->idStanicaPolaska)->setStanicaDolaska($row->idStanicaDolaska)->setVremePolaska($row->vremePolaska)->setCena($row->cena)->setAktivnost($row->aktivnost);
            $Items[]=$object;
        }
        return $Items;
    }
    public function dohvatiJedan($id){
        $resultSet=$this->getDbTable()->fetchRow("idKarta=$id");
        //$Item=array();
        //foreach ($resultSet as $row){
            $object=new Application_Model_Karta();
            $row = $resultSet;
            $object->setId($row->idKarta)->setTrasa($row->idTrase)->setStanicaPolaska($row->idStanicaPolaska)->setStanicaDolaska($row->idStanicaDolaska)->setVremePolaska($row->vremePolaska)->setCena($row->cena)->setAktivnost($row->aktivnost);
            //$Item[]=$object;
       //}
        return $object;
    }
    public function delete($id){
        $this->getDbTable()->delete("idKarta=$id");
    }
}

