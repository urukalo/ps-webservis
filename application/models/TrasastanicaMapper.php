<?php

class Application_Model_TrasastanicaMapper
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
            $this->setDbTable('Application_Model_DbTable_Trasastanica');
        }
        return $this->_dbTable;
    }
    public function save(Application_Model_Trasastanica $object){
        $data=array(
                  'idTrasaStanica'=>$object->getId(),
                  'idTrase'=>$object->getTrasa(),
                  'idStanica'=>$object->getStanica(),
                  'kmOd'=>$object->getKmOd(),
                  'kmDo'=>$object->getKmDo()
        ); 
        
        if(null===($idTrasaStanica=$object->getId())){
            unset($data['idTrasaStanica']);
            $this->getDbTable()->insert($data);
        }else{
            $this->getDbTable()->update($data,array('idTrasaStanica=?'=>$idTrasaStanica));
        }
    }
    public function dohvatiSve(){
        $resultSet=$this->getDbTable()->fetchAll('true');
        $Items=array();
        foreach ($resultSet as $row){
            $object=new Application_Model_Trasastanica();
            $object->setId($row->idTrasaStanica)->setTrasa($row->idTrase)->setStanica($row->idStanica)->setKmOd($row->kmOd)->setKmDo($row->kmDo);
            $Items[]=$object;
        }
        return $Items;
    }
    public function dohvatiJedan($id){
        $resultSet=$this->getDbTable()->fetchAll("idTrasaStanica=$id");
        $Item=array();
        foreach ($resultSet as $row){
            $object=new Application_Model_Trasastanica();
            $object->setId($row->idTrasaStanica)->setTrasa($row->idTrase)->setStanica($row->idStanica)->setKmOd($row->kmOd)->setKmDo($row->kmDo);
            $Item[]=$object;
        }
        return $Item;
    }
    
    public function dohvatiSveNaTrasi($id){
        $resultSet=$this->getDbTable()->fetchAll("idTrasa=$id");
        $Item=array();
        foreach ($resultSet as $row){
            $object=new Application_Model_Trasastanica();
            $object->setId($row->idTrasaStanica)->setTrasa($row->idTrase)->setStanica($row->idStanica)->setKmOd($row->kmOd)->setKmDo($row->kmDo);
            $Item[]=$object;
        }
        return $Item;
    }
    public function delete($id){
        $this->getDbTable()->delete("idTrasaStanica=$id");
    }
}

