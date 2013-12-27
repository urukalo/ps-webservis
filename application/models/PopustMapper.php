<?php

class Application_Model_PopustMapper
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
            $this->setDbTable('Application_Model_DbTable_Popust');
        }
        return $this->_dbTable;
    }
    public function save(Application_Model_Popust $object){
        $data=array(
                  'idPopust'=>$object->getId(),
                  'naziv'=>$object->getNaziv(),
                  'procenat'=>$object->getProcenat()
        ); 
        
        if(null===($idPopust=$object->getId())){
            unset($data['idPopust']);
            $this->getDbTable()->insert($data);
        }else{
            $this->getDbTable()->update($data,array('idPopust=?'=>$idPopust));
        }
    }
    public function dohvatiSve(){
        $resultSet=$this->getDbTable()->fetchAll();
        $Items="";
        foreach ($resultSet as $row){
            $object=$row->idPopust."_".$row->naziv."_".$row->procenat;
            $Items.=$object."#";
        }
        return $Items;
    }
     public function dohvatiSveWeb(){
        $resultSet=$this->getDbTable()->fetchAll('true');
        $Items=array();
        foreach ($resultSet as $row){
            $object=new Application_Model_Popust();
            $object->setId($row->idPopust)->setNaziv($row->naziv)->setProcenat($row->procenat);
            $Items[]=$object;
        }
        return $Items;
    }
    public function dohvatiJedan($id){
        $resultSet=$this->getDbTable()->fetchAll("idPopust=$id");
        $Item=array();
        foreach ($resultSet as $row){
            $object=new Application_Model_Popust();
            $object->setId($row->idPopust)->setNaziv($row->naziv)->setProcenat($row->procenat);
            $Item[]=$object;
        }
        return $Item;
    }
    public function delete($id){
        $this->getDbTable()->delete("idPopust=$id");
    }
}

