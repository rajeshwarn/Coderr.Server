﻿//using System;
//using System.Threading.Tasks;
//using Coderr.Server.ReportAnalyzer.Abstractions;
//using Coderr.Core.Api.Applications;
//

//namespace Coderr.Data.Applications
//{
//    public class GetApplicationByAppKeyHandler : IQueryHandler<GetApplicationByAppKey, ApplicationResult>
//    {
//        private readonly IAdoNetUnitOfWork _uow;

//        public GetApplicationByAppKeyHandler(SomeUow uow)
//        {
//            if (uow == null) throw new ArgumentNullException("uow");
//            _uow = uow;
//        }


//        public async Task<ApplicationResult> ExecuteAsync(IMessageContext context, GetApplicationByAppKey query)
//        {
//            using (var cmd = _uow.CreateCommand())
//            {
//                cmd.CommandText =
//                    "SELECT * FROM Applications WHERE AppKey = @id";

//                cmd.AddParameter("id", query.AppKey);
//                var result = await cmd.FirstOrDefaultAsync(new ApplicationMapper());
//                return new ApplicationResult(result);
//            }
//        }
//    }
//}

