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
	
	
	public partial class ICorDebugThread2
	{
		
		private Debugger.Interop.CorDebug.ICorDebugThread2 wrappedObject;
		
		internal Debugger.Interop.CorDebug.ICorDebugThread2 WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public ICorDebugThread2(Debugger.Interop.CorDebug.ICorDebugThread2 wrappedObject)
		{
			this.wrappedObject = wrappedObject;
			ResourceManager.TrackCOMObject(wrappedObject, typeof(ICorDebugThread2));
		}
		
		public static ICorDebugThread2 Wrap(Debugger.Interop.CorDebug.ICorDebugThread2 objectToWrap)
		{
			if ((objectToWrap != null))
			{
				return new ICorDebugThread2(objectToWrap);
			} else
			{
				return null;
			}
		}
		
		~ICorDebugThread2()
		{
			object o = wrappedObject;
			wrappedObject = null;
			ResourceManager.ReleaseCOMObject(o, typeof(ICorDebugThread2));
		}
		
		public bool Is<T>() where T: class
		{
			System.Reflection.ConstructorInfo ctor = typeof(T).GetConstructors()[0];
			System.Type paramType = ctor.GetParameters()[0].ParameterType;
			return paramType.IsInstanceOfType(this.WrappedObject);
		}
		
		public T As<T>() where T: class
		{
			try {
				return CastTo<T>();
			} catch {
				return null;
			}
		}
		
		public T CastTo<T>() where T: class
		{
			return (T)Activator.CreateInstance(typeof(T), this.WrappedObject);
		}
		
		public static bool operator ==(ICorDebugThread2 o1, ICorDebugThread2 o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(ICorDebugThread2 o1, ICorDebugThread2 o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			ICorDebugThread2 casted = o as ICorDebugThread2;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public void GetActiveFunctions(uint cFunctions, out uint pcFunctions, System.IntPtr pFunctions)
		{
			this.WrappedObject.GetActiveFunctions(cFunctions, out pcFunctions, pFunctions);
		}
		
		public uint ConnectionID
		{
			get
			{
				uint pdwConnectionId;
				this.WrappedObject.GetConnectionID(out pdwConnectionId);
				return pdwConnectionId;
			}
		}
		
		public ulong TaskID
		{
			get
			{
				ulong pTaskId;
				this.WrappedObject.GetTaskID(out pTaskId);
				return pTaskId;
			}
		}
		
		public uint VolatileOSThreadID
		{
			get
			{
				uint pdwTid;
				this.WrappedObject.GetVolatileOSThreadID(out pdwTid);
				return pdwTid;
			}
		}
		
		public void InterceptCurrentException(ICorDebugFrame pFrame)
		{
			this.WrappedObject.InterceptCurrentException(pFrame.WrappedObject);
		}
	}
}

#pragma warning restore 1591
