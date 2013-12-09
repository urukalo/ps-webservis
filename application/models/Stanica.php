<?php

class Application_Model_Stanica
{
    protected $_idStanica;
    protected $_naziv;
    
    public function getId() {
        return $this->_idStanica;
    }
    public function setId($data) {
        $this->_idStanica=$data;
        return $this;
    }
	
    public function getNaziv() {
        return $this->_naziv;
    }
    public function setNaziv($data) {
        $this->_naziv=$data;
        return $this;
    }
}

