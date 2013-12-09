<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * OVO TREBA PREBACITI U ORM
 *
 * @author Miki
 */
class Ekarta_RedVoznje {
    //put your code here
    
    public function redVoznje($idPolazak,$idDolazak){
        $redVoznje=new Application_Model_Redvoznje();
        $redVoznjeMapper= new Application_Model_RedvoznjeMapper();
        
    }
}
