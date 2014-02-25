How to test FlashDevelop HxCppDebugger
======================================

1. Setup Haxe

2. Build FlashDevelop

3. Setup your project


Setup Haxe
----------

You need a new enough Haxe, to support the HxCppDebugger. Sadly 3.0.1 is not new enough.

Either get it from git and build it (http://haxe.org/download/make) or get it from nightly
builds http://haxe.org/manual/haxe3#git-builds.

Then you need some haxe libs:
- haxelib install lime
- haxelib run lime setup
- haxelib run lime install openfl
- haxelib install actuate

More here: https://github.com/openfl/openfl/wiki

Build FlashDevelop
------------------

Currently the code is available on https://github.com/zobo/flashdevelop.git branch feature/hxcppdebugger

You will need to build this code. Open the solution and run it.


Setup your project
------------------

If you have a working project, take that, or create a new one, instructions here: http://haxe3.blogspot.com/2013/07/setting-up-flashdevelop-for-haxe-3-and.html

1. Add the FlashDevelop debugger "middleware" class path to your application.xml. They are located
in FlashDevelop release tree, that you checked out before. Something like this:

<source path="../../../FD/flashdevelop/FlashDevelop/Bin/Debug/Library/HAXE/classes" />

2. At the beginning of you static main function, add the following lines:

public staic function main()
{
  #if HXCPP_DEBUGGER
  new org.flashdevelop.cpp.debugger.HaxeRemote(true, "127.0.0.1");
  #end
  ...

3. Seletct "Debug" configuration and "windows" target on the toolbar and press F5, to compile and run with debugging.


Problems?
---------

If your code does not compile, it's probably something with haxe nightly, or some problem with the setup. Unrelated to the debugger.
I can't help much here, sorry.

If your code starts, but you don't see what you expect, start by enabling verbose debugger output:
- Tools/Program Settings...
- FlashDebugger
- Verbose Output - True

This will help analyze what is going on with the protocol.
