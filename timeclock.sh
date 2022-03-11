#!/bin/bash

echo "Running timeclock.sh..."

while[true]; do

read -p $"This is my promot: \n" input
timestamp =$(date + "%Y-%m-%d:%T")
echo $input
echo $timestamp

if[[$(input^^) == "STOP" ]]; then
break

#else if
elif [[ -z $input]];then
echo "The input is empty, please try again."
fi

done

for name in $[EmployeeName[@]]; do
echo $name >> ./ClockInOut.txt
done
