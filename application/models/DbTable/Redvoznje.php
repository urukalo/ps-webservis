<?php

class Application_Model_DbTable_Redvoznje extends Zend_Db_Table_Abstract
{
    protected $_name = 'redvoznje';
    protected $_primary = 'idRedVoznje';
     protected $_referenceMap=array(
        'Trasa'=>array(
            'columns'=>array('idTrasa'),
            'refTableClass'=>'Application_Model_DbTable_Trasa',
            'refColumns'=>array('idTrasa')
        )
    );
}

