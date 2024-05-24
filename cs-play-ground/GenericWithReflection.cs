using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace cs_play_ground
{
	internal class GenericWithReflection
	{
		void program() {
			// Step 1: Get the generic type definition
			Type genericTypeDefinition = typeof(List<>);

			// Step 2: Create a specific generic type using NoDefaultConstructor as the type argument
			Type specificType = genericTypeDefinition.MakeGenericType(typeof(NoDefaultConstructor));

			// Step 3: Create an instance of NoDefaultConstructor using the parameterized constructor
			ConstructorInfo ctor = typeof(NoDefaultConstructor).GetConstructor(new Type[] { typeof(string) });
			if (ctor != null)
			{
				object noDefaultCtorInstance = ctor.Invoke(new object[] { "TestName" });

				// Step 4: Create an instance of the constructed generic type List<NoDefaultConstructor>
				object listInstance = Activator.CreateInstance(specificType);
				MethodInfo addMethod = specificType.GetMethod("Add");
				addMethod.Invoke(listInstance, new object[] { noDefaultCtorInstance });

				// Verify the type and cast to List<NoDefaultConstructor>
				if (listInstance is List<NoDefaultConstructor> typedList)
				{
					Console.WriteLine("Successfully created a List<NoDefaultConstructor> instance.");
					// You can now use typedList as a List<NoDefaultConstructor>
					foreach (var item in typedList)
					{
						Console.WriteLine(item.Name);
					}
				}
				else
				{
					Console.WriteLine("Failed to create a List<NoDefaultConstructor> instance.");
				}
			}
			else
			{
				Console.WriteLine("Constructor not found.");
			}
		}
	}
}
