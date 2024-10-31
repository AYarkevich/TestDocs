namespace TestDocs;

/// <summary>
/// Test class for testing docs
/// </summary>
public class DocClass
{
    /// <summary>
    /// Test Boolean property
    /// </summary>
    public bool BoolProperty { get; set; }
    
    /// <summary>
    /// Test String property
    /// </summary>
    public string? StringProperty { get; set; }
    
    /// <summary>
    /// Test Integer property
    /// </summary>
    public bool IntegerProperty { get; set; }
    
    /// <summary>
    /// Test Float property
    /// </summary>
    public bool FloatProperty { get; set; }

    /// <summary>
    /// This method without params
    /// </summary>
    public void MethodWithoutParams()
    {
        
    }

    /// <summary>
    /// This method without params returns integer
    /// </summary>
    /// <returns>Just integer value</returns>
    public int MethodReturnsInteger()
    {
        return 0;
    }

    /// <summary>
    /// This method with parameters
    /// </summary>
    /// <param name="arg1">First parameter</param>
    /// <param name="arg2">Second parameter</param>
    public void MethodWithParams(int arg1, int arg2)
    {
        
    }    
    
    /// <summary>
    /// This method with parameters returns object
    /// </summary>
    /// <param name="arg1">First parameter</param>
    /// <param name="arg2">Second parameter</param>
    public object MethodWithParamsReturnsObject(int arg1, int arg2)
    {
        return new object();
    }
}