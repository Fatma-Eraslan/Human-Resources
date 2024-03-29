﻿using DataAccess.Repositories;
using HRMVCProjectDataAccess.Data;
using HRMVCProjectDataAccess.Repositories.Abstract;
using HRMVCProjectEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HRMVCProjectEntities.Concrete.Enums;

namespace HRMVCProjectDataAccess.Repositories.Concrete
{
    public class PermissionRepository : GenericRepository<Permission> , IPermissionRepository
    {
        private readonly HRMVCProjectDbContext db;

        public PermissionRepository(HRMVCProjectDbContext db ) : base(db)
        {
            this.db = db;
        }
        public ICollection<Permission> GetAllById(int id)
        {
            return (ICollection<Permission>)db.Employees.Include(a => a.Permissions).Where(a => a.Id == id).ToList();
        }

        public bool AddPermission(Permission permission, Employee employee)
        {
            var _employee = db.Employees.FirstOrDefault(x => x.Id == employee.Id);

            if (permission != null && employee != null)
            {
                _employee.Permissions.Add(permission);
                return db.SaveChanges() > 0;
            }
            return false;

        }
        public IEnumerable<Permission> GetAllByCompanyId(int companyId)
        {
            List<Permission> permissions = new List<Permission>();

            foreach (Permission item in db.Permissions.Include(a=>a.Employees))
            {
                foreach (Employee item2 in item.Employees)
                {
                    if (item2.CompanyId == companyId)
                    {
                        permissions.Add(item);
                    }
                }
            }
            return permissions;
        }

        public IEnumerable<Permission> GetPendingPermissions(int companyId)
        {
            List<Permission> permissions = new List<Permission>();

            foreach (Permission item in db.Permissions.Include(x => x.Employees))
            {
                foreach (Employee item2 in item.Employees)
                {
                    if (item2.CompanyId == companyId && item.ReplyState == ReplyState.Beklemede)
                    {
                        permissions.Add(item);
                    }
                }
            }
            return permissions;
        }

    }
}
