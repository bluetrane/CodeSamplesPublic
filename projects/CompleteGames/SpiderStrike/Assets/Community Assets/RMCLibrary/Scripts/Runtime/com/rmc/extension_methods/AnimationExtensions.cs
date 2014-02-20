/**
 * Copyright (C) 2005-2013 by Rivello Multimedia Consulting (RMC).                    
 * code [at] RivelloMultimediaConsulting [dot] com                                                  
 *                                                                      
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the      
 * "Software"), to deal in the Software without restriction, including  
 * without limitation the rights to use, copy, modify, merge, publish,  
 * distribute, sublicense, and#or sell copies of the Software, and to   
 * permit persons to whom the Software is furnished to do so, subject to
 * the following conditions:                                            
 *                                                                      
 * The above copyright notice and this permission notice shall be       
 * included in all copies or substantial portions of the Software.      
 *                                                                      
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,      
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF   
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
 * IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR    
 * OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.                                      
 */
// Marks the right margin of code *******************************************************************


//--------------------------------------
//  Imports
//--------------------------------------
using UnityEngine;

//--------------------------------------
//  Namespace
//--------------------------------------
//NOTE: NO NEED TO add 'using com.rmc.extension_methods;' in any class for this to work
	
	//--------------------------------------
	//  Namespace Properties
	//--------------------------------------
	
	
	//--------------------------------------
	//  Class Attributes
	//--------------------------------------
	
	//--------------------------------------
	//  Class
	//--------------------------------------

	/// <summary>
	/// 
	/// Its like 'extending' that class but without needing to extend it. Magical!
	/// 
	/// </summary>
using com.rmc.projects.spider_strike.mvcs.view.signals;


	public static class AnimationExtensions 
	{

		//--------------------------------------
		//  Properties
		//--------------------------------------
		
		// GETTER / SETTER
		///<summary>
		///	This is a sample getter/setter property.
		///</summary>
			
		// PUBLIC
		///<summary>
		///	This is a sample public property.
		///</summary>
		
		// PUBLIC STATIC
		///<summary>
		///	This is a sample public static property.
		///</summary>
		
		// PRIVATE
		///<summary>
		///	This is a sample private property.
		///</summary>
		
		// PRIVATE STATIC
		///<summary>
		///	This is a sample private static property.
		///</summary>
		
		
		//--------------------------------------
		//  Methods
		//--------------------------------------	
		
		// PUBLIC
		
		// PUBLIC STATIC
		/// <summary>
		/// Gets or sets the user interface animation complete.
		/// </summary>
		/// <value>The user interface animation complete.</value>
		public static UIAnimationCompleteSignal uiAnimationCompleteSignal {set; get;}


		public static UIAnimationCompleteSignal getUIAnimationCompleteSignal (this Animation aAnimation) 
		{
			uiAnimationCompleteSignal = new UIAnimationCompleteSignal();
			return uiAnimationCompleteSignal;
			
		}

		
		// PRIVATE
		
		// PRIVATE STATIC
		
		
		//--------------------------------------
		//  Events
		//--------------------------------------

	}
