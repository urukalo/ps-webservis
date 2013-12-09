<?php

class Application_Model_OtkazanavoznjaMapper
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
            $this->setDbTable('Application_Model_DbTable_Otkazanavoznja');
        }
        return $this->_dbTable;
    }
    public function save(Application_Model_Otkazanavoznja $object){
        $data=array(
                  'idOtkazanaVoznja'=>$object->getId(),
                  'idTrase'=>$object->getTrasa(),
                  'datum'=>$object->getDatum(),
                  'vreme'=>$object->getVreme()
        ); 
        
        if(null===($idOtkazanaVoznja=$object->getId())){
            unset($data['idOtkazanaVoznja']);
            $this->getDbTable()->insert($data);
        }else{
            $this->getDbTable()->update($data,array('idOtkazanaVoznja=?'=>$idOtkazanaVoznja));
        }
    }
    public function dohvatiSve(){
        $resultSet=$this->getDbTable()->fetchAll('true');
        $Items=array();
        foreach ($resultSet as $row){
            $object=new Application_Model_Otkazanavoznja();
            $object->setId($row->idOtkazanaVoznja)->setTrasa($row->idTrase)->setDatum($row->datum)->setVreme($row->vreme);
            $Items[]=$object;
        }
        return $Items;
    }
    public function dohvatiJedan($id){
        $resultSet=$this->getDbTable()->fetchAll("idOtkazanaVoznja=$id");
        $Item=array();
        foreach ($resultSet as $row){
            $object=new Application_Model_Otkazanavoznja();
            $object->setId($row->idOtkazanaVoznja)->setTrasa($row->idTrase)->setDatum($row->datum)->setVreme($row->vreme);
            $Item[]=$object;
        }
        return $Item;
    }
    public function delete($id){
        $this->getDbTable()->delete("idOtkazanaVoznja=$id");
    }
}

