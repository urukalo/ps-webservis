<?php

class Application_Model_DbTable_Trasastanica extends Zend_Db_Table_Abstract
{
    protected $_name = 'trasastanica';
    protected $_primary = 'idTrasaStanica';
    protected $_dependentTables=array('Application_Model_DbTable_Karta');
    protected $_referenceMap=array(
            'Trasa'=>array(
                    'columns'=>array('idTrasa'),
                    'refTableClass'=>'Application_Model_DbTable_Trasa',
                    'refColumns'=>array('idTrasa')
            ),
            'Stanica'=>array(
                    'columns'=>array('idStanica'),
                    'refTableClass'=>'Application_Model_DbTable_Stanica',
                    'refColumns'=>array('idStanica')
            )
    );
}

