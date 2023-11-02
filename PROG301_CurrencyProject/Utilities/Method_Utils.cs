using System.Reflection;

namespace PROG301_CurrencyProject.Utility
{
    public static class Method_Utils
    {
        public static T InvokeMethod<T>(Type targetType, string methodName, object[] methodParameters)
        {
            // Check if targetType is a class and has a parameterless constructor
            if (targetType.IsClass && targetType.GetConstructor(Type.EmptyTypes) != null)
            {
                // Create an instance of the target class
                object targetInstance = Activator.CreateInstance(targetType);

                // Get the method info
                MethodInfo methodInfo = targetType.GetMethod(methodName);

                // Check if the method exists and is accessible
                if (methodInfo != null && methodInfo.IsPublic)
                {
                    // Invoke the method and return its result
                    object result = methodInfo.Invoke(targetInstance, methodParameters);

                    if (result is T)
                    {
                        return (T)result;
                    }
                    else
                    {
                        // Handle the case where the result is not of type T
                        throw new InvalidCastException("The method did not return the expected type.");
                    }
                }
                else
                {
                    throw new MissingMethodException("The specified method was not found or is not accessible.");
                }
            }
            else
            {
                throw new InvalidOperationException("The specified type is not a class or does not have a parameterless constructor.");
            }
        }

        public static TResult InvokeMethod<TInstance, TResult>(Type targetType, string methodName, object[] methodParameters)
        {
            // Check if targetType is a class and has a parameterless constructor
            if (targetType.IsClass && targetType.GetConstructor(Type.EmptyTypes) != null)
            {
                // Create an instance of the target class
                object targetInstance = Activator.CreateInstance(targetType);

                // Get the method info
                MethodInfo methodInfo = targetType.GetMethod(methodName);

                // Check if the method exists and is accessible
                if (methodInfo != null && methodInfo.IsPublic)
                {
                    // Invoke the method and return its result
                    object result = methodInfo.Invoke(targetInstance, methodParameters);

                    if (result is TResult castedResult)
                    {
                        return castedResult;
                    }
                    else
                    {
                        // Handle the case where the result cannot be cast to the specified return type
                        throw new InvalidCastException("The method result cannot be cast to the specified return type.");
                    }
                }
                else
                {
                    throw new MissingMethodException("The specified method was not found or is not accessible.");
                }
            }
            else
            {
                throw new InvalidOperationException("The specified type is not a class or does not have a parameterless constructor.");
            }
        }

    }
}