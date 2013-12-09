<?php

class Application_Model_Otkazanavoznja
{
    protected $_idOtkazanaVoznja;
    protected $_idTrasa;
    protected $_datum;
    protected $_vreme;
    
    public function getId() {
        return $this->_idOtkazanaVoznja;
    }
    public function setId($data) {
        $this->_idOtkazanaVoznja=$data;
        return $this;
    }
	
    public function getTrasa() {
        return $this->_idTrasa;
    }
    public function setTrasa($data) {
        $this->_idTrasa=$data;
        return $this;
    }
	
    public function getDatum() {
        return $this->_datum;
    }
    public function setDatum($data) {
        $this->_datum=$data;
        return $this;
    }
	
    public function getVreme() {
        return $this->_vreme;
    }
    public function setVreme($data) {
        $this->_vreme=$data;
        return $this;
    }
}

