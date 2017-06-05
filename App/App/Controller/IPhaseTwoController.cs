using App.Entity;
using System.Collections.Generic;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Phase two controller interface
    /// Author : Catalin Radoiu 
    /// 
    /// </summary>
    public interface IPhaseTwoController
    {
        void deleteRejectedProposals();

        List<User> getReviewers();

        void UpdateConference(Conference conference);

        Conference ActiveConference();

        void updateReview(Review review);

        Review getReview(int reviewId);

        List<Review> getReviewsByIdReviewer(int reviewerId);

        Review getReviewByIdProposalIdReviewer(int proposalId, int reviewerId);

        void addReview(Review review);

        Proposal getProposal(int proposalId);

        List<Proposal> getProposals();

        void removeReview(int reviewId);

        User getReviewer(int reviewerId);

        List<Review> getReviewsByProposalId(int proposalId);
    }
}