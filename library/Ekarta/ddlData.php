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
class Ekarta_ddlData implements Serializable {

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

    /**
     * 
     * @return string
     */
    public function serialize() {
        return serialize(
                array(
                    "key" => $this->key,
                    "value" => $this->value)
        );
    }

    /**
     * 
     * @param string $serialized
     */
    public function unserialize($serialized) {
        $tmp = unserialize($serialized);
        $this->key = $tmp["key"];
        $this->value = $tmp["value"];
    }

}
