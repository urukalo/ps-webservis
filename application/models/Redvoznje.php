<?php

class Application_Model_Redvoznje {

    /**
     *
     * @var int
     */
    public $_idRedVoznje;

    /**
     *
     * @var int
     */
    public $_idTrasa;

    /**
     *
     * @var int
     */
    public $_dan;

    /**
     *
     * @var string
     */
    public $_vremePolaska;

    public function getId() {
        return $this->_idRedVoznje;
    }

    public function setId($data) {
        $this->_idRedVoznje = $data;
        return $this;
    }

    public function getTrasa() {
        return $this->_idTrasa;
    }

    public function setTrasa($data) {
        $this->_idTrasa = $data;
        return $this;
    }

    public function getDan() {
        return $this->_dan;
    }

    public function setDan($data) {
        $this->_dan = $data;
        return $this;
    }

    public function getVremePolaska() {
        return $this->_vremePolaska;
    }

    public function setVremePolaska($data) {
        $this->_vremePolaska = $data;
        return $this;
    }

}
