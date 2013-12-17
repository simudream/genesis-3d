// cs0071.cs: An explicit interface implementation of an event must use property syntax
// Line: 13

using System;

public delegate void Foo (object source);

interface IFoo {
	event Foo OnFoo;
}
	
class ErrorCS0071 : IFoo {
	event Foo IFoo.OnFoo () { }
	public static void Main () {
	}
}
