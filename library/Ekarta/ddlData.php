<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of ddlData
 *
 * @author Miki
 */
class Ekarta_ddlData {

    //put your code here
    /**
     *
     * @var string
     */
    public $key;

    /**
     *
     * @var string
     */
    public $value;

    /**
     * 
     * @param string $key
     * @param string $value
     */
    public function __construct($key, $value) {
        $this->key = $key;
        $this->value = $value;
    }

}
