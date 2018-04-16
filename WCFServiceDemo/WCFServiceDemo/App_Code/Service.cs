using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	float IService.Add(float a, float b)
	{
		return a+b;
	}

	float IService.Divide(float a, float b)
	{
		if (b!=0) return a/b;
		return -1;
	}

	string IService.GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	CompositeType IService.GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}

	float IService.Multiply(float a, float b)
	{
		return a*b;
	}

	float IService.Subtract(float a, float b)
	{
		return a-b;
	}
}
