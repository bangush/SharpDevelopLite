// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

// This file is automatically generated - any changes will be lost

#pragma warning disable 1591

namespace Debugger.Wrappers.CorDebug
{
	using System;
	
	
	public enum CorDebugChainReason : int
	{
		
		CHAIN_NONE = 0,
		
		CHAIN_CLASS_INIT = 1,
		
		CHAIN_EXCEPTION_FILTER = 2,
		
		CHAIN_SECURITY = 4,
		
		CHAIN_CONTEXT_POLICY = 8,
		
		CHAIN_INTERCEPTION = 16,
		
		CHAIN_PROCESS_START = 32,
		
		CHAIN_THREAD_START = 64,
		
		CHAIN_ENTER_MANAGED = 128,
		
		CHAIN_ENTER_UNMANAGED = 256,
		
		CHAIN_DEBUGGER_EVAL = 512,
		
		CHAIN_CONTEXT_SWITCH = 1024,
		
		CHAIN_FUNC_EVAL = 2048,
	}
}

#pragma warning restore 1591
