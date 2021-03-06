﻿using App.Entity;
using App.Repository.Impl;
using App.Utils;
using System.Collections.Generic;
using System.Linq;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Phase two controller implementation
    /// Author : Andu Popa
    /// 
    /// </summary>
    public class PhaseTwoController
    {
        private ConferenceRepository conferenceRepository;
        private ReviewRepository reviewRepo;
        private ProposalRepository proposalRepo;
        private UserRepository userRepo;
        private UserRoleRepository userRoleRepo;
        private RoleRepository roleRepository;

        public PhaseTwoController(
            ReviewRepository reviewRepo,
            ProposalRepository proposalRepo,
            UserRepository userRepo,
            ConferenceRepository conferenceRepository,
            UserRoleRepository userRoleRepo,
            RoleRepository roleRepository
        )
        {
            this.reviewRepo = reviewRepo;
            this.proposalRepo = proposalRepo;
            this.userRepo = userRepo;
            this.conferenceRepository = conferenceRepository;
            this.userRoleRepo = userRoleRepo;
            this.roleRepository = roleRepository;
        }

        /// <summary>
        /// Return a listof reviews whose proposal has the ID equal to the parameter proposalId
        /// </summary>
        /// <param name="proposalId"></param>
        /// <returns></returns>
        public List<Review> getReviewsByProposalId(int proposalId)
        {
            List<Review> reviews = reviewRepo.All();
            reviews = reviews.Where(rev => rev.Proposal.ProposalId == proposalId).ToList();
            return reviews;
        }

        /// <summary>
        /// Returns a reviewer(user) with the ID given as parameter
        /// </summary>
        /// <param name="reviewerId"></param>
        /// <returns></returns>
        public User getReviewer(int reviewerId)
        {
            return userRepo.Find(reviewerId);
        }

        /// <summary>
        /// Removes the review with the given ID from the database
        /// </summary>
        /// <param name="reviewId"></param>
        public void removeReview(int reviewId)
        {
            reviewRepo.Delete(reviewRepo.Find(reviewId));
        }

        /// <summary>
        /// Returns a list of all the proposals
        /// </summary>
        /// <returns></returns>
        public List<Proposal> getProposals()
        {
            return proposalRepo.All();
        }

        public List<Review> getReviews()
        {
            return reviewRepo.All();
        }

        /// <summary>
        /// Returns a proposal with the given ID
        /// </summary>
        /// <param name="proposalId"></param>
        /// <returns></returns>
        public Proposal getProposal(int proposalId)
        {
            return proposalRepo.Find(proposalId);
        }

        /// <summary>
        /// Saves the given review in the database
        /// </summary>
        /// <param name="review"></param>
        public void addReview(Review review)
        {
            reviewRepo.Add(review);
        }

        /// <summary>
        /// Returns a review with the given proposal ID and reviewer ID
        /// </summary>
        /// <param name="proposalId"></param>
        /// <param name="reviewerId"></param>
        /// <returns></returns>
        public Review getReviewByIdProposalIdReviewer(int proposalId, int reviewerId)
        {
            List<Review> reviews = reviewRepo.All();
            List<Review> result = reviews.Where(review => review.Proposal.ProposalId == proposalId && review.Reviewer.UserId == reviewerId).ToList();
            if(result.Count > 0)
            {
                return result.First();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Returns a list of reviews with the given reviewer ID
        /// </summary>
        /// <param name="reviewerId"></param>
        /// <returns></returns>
        public List<Review> getReviewsByIdReviewer(int reviewerId)
        {
            return reviewRepo.All().Where(review => review.Reviewer.UserId == reviewerId).ToList();
        }

        public List<User> getReviewersThatAcceptedProposal(int idProposal)
        {
            return getReviewers().Where(reviewer => (getReviews().Where(review => (review.Reviewer.UserId == reviewer.UserId && review.Proposal.ProposalId == idProposal)).ToList().Count > 0)).ToList();
        }

        /// <summary>
        /// Return a review with the given ID
        /// </summary>
        /// <param name="reviewId"></param>
        /// <returns></returns>
        public Review getReview(int reviewId)
        {
            return reviewRepo.Find(reviewId);
        }

        /// <summary>
        /// Updates the review with the same id as the one given as parameter to the new one.
        /// </summary>
        /// <param name="review"></param>
        public void updateReview(Review review)
        {
            reviewRepo.Update(review);
        }

        public Conference ActiveConference()
        {
            return conferenceRepository.GetActiveConference();
        }

        public void UpdateConference(Conference conference)
        {
            conferenceRepository.Update(conference);
        }

        public List<User> getReviewers()
        {
            return userRepo.All().Where(user => userRoleRepo.All().Where(role => role.RoleId == roleRepository.getBySlug("reviewer").RoleId).ToList().Where(userRole => userRole.UserId == user.UserId).ToList().Count > 0).ToList();
        }

        public void deleteRejectedProposals()
        {
            List<int> rejectedProposalsIds = reviewRepo.getRejectedProposalsIds();

            foreach (int id in rejectedProposalsIds)
            {

                foreach (User author in getProposal(id).Authors)
                {
                    Role role = roleRepository.getBySlug("listner");
                    author.UserRoles = new List<UserRole>() { new UserRole() { Role = role, RoleId = role.RoleId, User = author, UserId = author.UserId } };
                    userRepo.Update(author);

                }

                proposalRepo.Delete(proposalRepo.Find(id));
            }
        }

        public void saveChanges()
        {
            reviewRepo.saveChanges();
            roleRepository.saveChanges();
            conferenceRepository.saveChanges();
            proposalRepo.saveChanges();
            userRepo.saveChanges();
            userRoleRepo.saveChanges();
        }
    }
}