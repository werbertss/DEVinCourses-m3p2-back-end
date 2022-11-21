using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Exceptions;
using NDDTraining.Domain.Interfaces.Repositories;
using NDDTraining.Domain.Interfaces.Services;
using NDDTraining.Domain.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDTraining.Domain.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepository;

        public ActivityService (IActivityRepository activityService)
        {
            _activityRepository = activityService;
        }

        public void Insert(ActivityDTO activity)
        {
            //insere o curso no banco de dados
            _activityRepository.Insert(new Activity(activity));

        }
    }
}
