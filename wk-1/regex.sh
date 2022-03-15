#usr/bin/bash

test = "Hello, World!"
reg = "^[0-9]"

#if [[ $test =~[0-9] ]];then
#echo "test is numbers"
#else
#echo "test is not numbers"
#fi

if [[ $test =~$reg ]];then
echo  "yes"
else
echo "no"
fi
