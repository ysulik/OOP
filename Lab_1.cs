﻿using System;
class Program {
static void Main() {
Console.WriteLine("");
A ObjectA = new A();
Console.WriteLine("a/b= "+ObjectA.c+"\na— = "+ObjectA.c1+"\na*b= "+ObjectA.c2);



}
}
class A{
private float a=10 ,b=4;
public float c{
get{ return a/=b;}
}
public float c1{
get{ return a--;}
}
public float c2{
get{ return a*b;}
}
}
