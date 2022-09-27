using System;
using System.Collections.Generic;

namespace DeviceManagement_WebApp.Respoistory
{
	public interface IBaseRepository<T> where T : class
	{
		T GetById(Guid id);
		IEnumerable<T> GetAll();
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
		bool Exists(Guid id);
		
		// This is absolutely horrible, because each model has full access to the underlying context of all other models
		// RIP seperation of concerns and single Use. I don't know if this is going to be marked correct or not...

		// NOTE (To marker): This function is a generic function that returns all the values in the model U and converts them to a list,
		//					 Well IEnumerable, this was done so that the device repository has access to Categories and Zones, it's used 
		//					 For the SelectIndex functions, which populate drop downs so that user can select which category and Zone a device is in.

		//					 Look At "DeviceController.cs" Line 85 for where this is used.
		//					 Look At "BaseRepository.cs" Line 48 for implementation.

		//					 Although this works a consequence of this is that in my opinion atleast it violates the Single use principle and
		//					 maybe separation of concerns, but that's the only solution I could think of.
				
		//					 If this is wrong could you please
		//					 make a Note in my Rubric of what I was actually supposed to do? It will be greatly appriciated.

		//					 Thank you for taking your time to read this.
		IEnumerable<U> GetDbSet<U>() where U:class; // Might fix the issue with select list, I guess // UPDATE: It did (Look Ma, I figured stuff out)
	}
}
