string[] arr = new string[4]{"hello","2","world",":-)"};
string[] newArr = new string[4];
int n = 0;

for(int i=0; i<arr.Length; i++){
    if(arr[i].Length <= 3){
        newArr[n] = arr[i];
        n++;
    }
}

for(int i=0; i<newArr.Length; i++){
    Console.Write($"{newArr[i]} ");
}