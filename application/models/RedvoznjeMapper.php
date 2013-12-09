<?php

class Application_Model_RedvoznjeMapper
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
            $this->setDbTable('Application_Model_DbTable_Redvoznje');
        }
        return $this->_dbTable;
    }
    public function save(Application_Model_Redvoznje $object){
        $data=array(
                  'idRedVoznje'=>$object->getId(),
                  'idTrase'=>$object->getTrasa(),
                  'dan'=>$object->getDan(),
                  'vreme'=>$object->getVreme()
        ); 
        
        if(null===($idRedVoznje=$object->getId())){
            unset($data['idRedVoznje']);
            $this->getDbTable()->insert($data);
        }else{
            $this->getDbTable()->update($data,array('idRedVoznje=?'=>$idRedVoznje));
        }
    }
    public function dohvatiSve(){
        $resultSet=$this->getDbTable()->fetchAll('true');
        $Items=array();
        foreach ($resultSet as $row){
            $object=new Application_Model_Redvoznje();
            $object->setId($row->idRedVoznje)->setTrasa($row->idTrase)->setDan($row->dan)->setVreme($row->vreme);
            $Items[]=$object;
        }
        return $Items;
    }
    public function dohvatiJedan($id){
        $resultSet=$this->getDbTable()->fetchAll("idRedVoznje=$id");
        $Item=array();
        foreach ($resultSet as $row){
            $object=new Application_Model_Redvoznje();
            $object->setId($row->idRedVoznje)->setTrasa($row->idTrase)->setDan($row->dan)->setVreme($row->vreme);
            $Item[]=$object;
        }
        return $Item;
    }
    public function dohvatiZaStanice(){
        
    }

    public function delete($id){
        $this->getDbTable()->delete("idRedVoznje=$id");
    }
}

