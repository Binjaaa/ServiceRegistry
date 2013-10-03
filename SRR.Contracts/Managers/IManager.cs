namespace SRR.Contracts.Managers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="C">Create viewmodel type</typeparam>
    /// <typeparam name="U">Update(edit) viewmodel type</typeparam>
    /// <typeparam name="I">Index viewmodel type</typeparam>
    public interface IManager<C, U, I>
        where C : class
        where U : class
        where I : class
    {
        I Index();
        C GetCreate();

        void PostCreate(C createVM);
        void Delete(long ID);
        void Update(U updatedObject);
        U Update(int updatedObjectPrimaryKey);
    }
}
