#!/bin/bash

echo "Running timeclock.sh..."

EmployeeNames=()

while [ true ]; do

read -p $'This is my prompt: \n' input
timestamp=$(date +"%Y-%m-%d:%T")
echo $input
echo $timestamp

if [[ ${input^^} == "STOP" ]]; then
break

#else if
elif [[ -z $input ]];then
echo "The input is empty, please try again."
fi

EmployeeNames+=($input:$timestamp)
sleep 2

done

for name in ${EmployeeNames[@]}; do
echo $name >> ./ClockInOut.txt
done

echo "Exiting Timeclock"
