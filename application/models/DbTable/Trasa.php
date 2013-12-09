<?php

class Application_Model_DbTable_Trasa extends Zend_Db_Table_Abstract
{
    protected $_name = 'trasa';
    protected $_primary = 'idTrasa';
    protected $_dependentTables=array('Application_Model_DbTable_Karta','Application_Model_DbTable_Redvoznje','Application_Model_DbTable_Otkazanavoznja','Application_Model_DbTable_Trasastanica');
}

