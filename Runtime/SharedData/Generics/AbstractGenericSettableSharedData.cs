namespace Flatpack.Architecture.SharedData.Generics
{
    public abstract class AbstractGenericSettableSharedData<T>: AbstractGenericSharedData<T>
    {
        public abstract void SetData(T value);
    }
}