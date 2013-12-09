<?php

class Application_Model_Trasa
{
    protected $_idTrasa;
    protected $_idStanicaPolaska;
    protected $_idStanicaDolaska;
    protected $_ukupnoKm;
    
    public function getId() {
        return $this->_idTrasa;
    }
    public function setId($data) {
        $this->_idTrasa=$data;
        return $this;
    }
	
    public function getStanicaPolaska() {
        return $this->_idStanicaPolaska;
    }
    public function setStanicaPolaska($data) {
        $this->_idStanicaPolaska=$data;
        return $this;
    }
	
    public function getStanicaDolaska() {
        return $this->_idStanicaDolaska;
    }
    public function setStanicaDolaska($data) {
        $this->_idStanicaDolaska=$data;
        return $this;
    }
	
    public function getUkupnoKm() {
        return $this->_ukupnoKm;
    }
    public function setUkupnoKm($data) {
        $this->_ukupnoKm=$data;
        return $this;
    }
}

