
/// <summary>
/// Reference variable type
/// </summary>
/// <typeparam name="ValueType"></typeparam>
[System.Serializable]
public class GenericReference<ValueType>
{
    public bool UseConstant = true;
    public ValueType ConstantValue;
    public GenericVariable<ValueType> Variable;

    public GenericReference(ValueType value)
    {
        UseConstant = true;
        ConstantValue = value;
    }

    public ValueType Value
    {
        get { return UseConstant ? ConstantValue : Variable.Value; }
        set
        {
            if (UseConstant)
                ConstantValue = value;
            else
                Variable.Value = value;
        }
    }

    public static implicit operator ValueType(GenericReference<ValueType> reference)
    {
        return reference.Value;
    }
}