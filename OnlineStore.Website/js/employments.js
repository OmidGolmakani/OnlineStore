﻿'use strict';

var $woman = $('#Gender_1'),
    $man = $('#Gender_0'),
    $martialRow = $('.martial-row');

$woman.on('click', function () {
    $martialRow.addClass('hide');
});
$man.on('click', function () {
    $martialRow.removeClass('hide');
});

