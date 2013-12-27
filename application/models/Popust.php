<?php

class Application_Model_Popust
{
    /**
     *
     * @var int 
     */
    public $_idPopust;
    /**
     *
     * @var string 
     */
    public $_naziv;
    /**
     *
     * @var int 
     */
    public $_procenat;
    
    public function getId() {
        return $this->_idPopust;
    }
    public function setId($data) {
        $this->_idPopust=$data;
        return $this;
    }
    public function getNaziv() {
        return $this->_naziv;
    }
    public function setNaziv($data) {
        $this->_naziv=$data;
        return $this;
    }
    public function getProcenat() {
        return $this->_procenat;
    }
    public function setProcenat($data) {
        $this->_procenat=$data;
        return $this;
    }
}

