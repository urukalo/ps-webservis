<?php

class Application_Model_TrasaStanica
{
    protected $_idTrasaStanica;
    protected $_idTrasa;
    protected $_idStanica;
    protected $_kmOd;
    protected $_kmDo;
    
    public function getId() {
        return $this->_idTrasaStanica;
    }
    public function setId($data) {
        $this->_idTrasaStanica=$data;
        return $this;
    }
	
    public function getTrasa() {
        return $this->_idTrasa;
    }
    public function setTrasa($data) {
        $this->_idTrasa=$data;
        return $this;
    }
	
    public function getStanica() {
        return $this->_idStanica;
    }
    public function setStanica($data) {
        $this->_idStanica=$data;
        return $this;
    }
	
    public function getKmOd() {
        return $this->_kmOd;
    }
    public function setKmOd($data) {
        $this->_kmOd=$data;
        return $this;
    }
	
    public function getKmDo() {
        return $this->_kmDo;
    }
    public function setKmDo($data) {
        $this->_kmDo=$data;
        return $this;
    }
}

