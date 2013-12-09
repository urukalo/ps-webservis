<?php

class Application_Model_DbTable_Stanica extends Zend_Db_Table_Abstract
{
    protected $_name = 'stanica';
    protected $_primary = 'idStanica';
    protected $_dependentTables=array('Application_Model_DbTable_Trasastanica');
}

