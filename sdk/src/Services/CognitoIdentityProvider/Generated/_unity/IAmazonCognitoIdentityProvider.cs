/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */

using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CognitoIdentityProvider.Model;

namespace Amazon.CognitoIdentityProvider
{
    /// <summary>
    /// Interface for accessing CognitoIdentityProvider
    ///
    /// Using the Amazon Cognito User Pools API, you can create a user pool to manage directories
    /// and users. You can authenticate a user to obtain tokens related to user identity and
    /// access policies.
    /// 
    ///  
    /// <para>
    /// This API reference provides information about user pools in Amazon Cognito User Pools.
    /// </para>
    ///  
    /// <para>
    /// For more information, see the Amazon Cognito Documentation.
    /// </para>
    /// </summary>
    public partial interface IAmazonCognitoIdentityProvider : IAmazonService, IDisposable
    {

        
        #region  AddCustomAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the AddCustomAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCustomAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AddCustomAttributes">REST API Reference for AddCustomAttributes Operation</seealso>
        void AddCustomAttributesAsync(AddCustomAttributesRequest request, AmazonServiceCallback<AddCustomAttributesRequest, AddCustomAttributesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminAddUserToGroup


        /// <summary>
        /// Initiates the asynchronous execution of the AdminAddUserToGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminAddUserToGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminAddUserToGroup">REST API Reference for AdminAddUserToGroup Operation</seealso>
        void AdminAddUserToGroupAsync(AdminAddUserToGroupRequest request, AmazonServiceCallback<AdminAddUserToGroupRequest, AdminAddUserToGroupResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminConfirmSignUp


        /// <summary>
        /// Initiates the asynchronous execution of the AdminConfirmSignUp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminConfirmSignUp operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminConfirmSignUp">REST API Reference for AdminConfirmSignUp Operation</seealso>
        void AdminConfirmSignUpAsync(AdminConfirmSignUpRequest request, AmazonServiceCallback<AdminConfirmSignUpRequest, AdminConfirmSignUpResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminCreateUser


        /// <summary>
        /// Initiates the asynchronous execution of the AdminCreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminCreateUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminCreateUser">REST API Reference for AdminCreateUser Operation</seealso>
        void AdminCreateUserAsync(AdminCreateUserRequest request, AmazonServiceCallback<AdminCreateUserRequest, AdminCreateUserResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminDeleteUser


        /// <summary>
        /// Initiates the asynchronous execution of the AdminDeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDeleteUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUser">REST API Reference for AdminDeleteUser Operation</seealso>
        void AdminDeleteUserAsync(AdminDeleteUserRequest request, AmazonServiceCallback<AdminDeleteUserRequest, AdminDeleteUserResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminDeleteUserAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the AdminDeleteUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDeleteUserAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUserAttributes">REST API Reference for AdminDeleteUserAttributes Operation</seealso>
        void AdminDeleteUserAttributesAsync(AdminDeleteUserAttributesRequest request, AmazonServiceCallback<AdminDeleteUserAttributesRequest, AdminDeleteUserAttributesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminDisableProviderForUser


        /// <summary>
        /// Initiates the asynchronous execution of the AdminDisableProviderForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDisableProviderForUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableProviderForUser">REST API Reference for AdminDisableProviderForUser Operation</seealso>
        void AdminDisableProviderForUserAsync(AdminDisableProviderForUserRequest request, AmazonServiceCallback<AdminDisableProviderForUserRequest, AdminDisableProviderForUserResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminDisableUser


        /// <summary>
        /// Initiates the asynchronous execution of the AdminDisableUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDisableUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableUser">REST API Reference for AdminDisableUser Operation</seealso>
        void AdminDisableUserAsync(AdminDisableUserRequest request, AmazonServiceCallback<AdminDisableUserRequest, AdminDisableUserResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminEnableUser


        /// <summary>
        /// Initiates the asynchronous execution of the AdminEnableUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminEnableUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminEnableUser">REST API Reference for AdminEnableUser Operation</seealso>
        void AdminEnableUserAsync(AdminEnableUserRequest request, AmazonServiceCallback<AdminEnableUserRequest, AdminEnableUserResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminForgetDevice


        /// <summary>
        /// Initiates the asynchronous execution of the AdminForgetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminForgetDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminForgetDevice">REST API Reference for AdminForgetDevice Operation</seealso>
        void AdminForgetDeviceAsync(AdminForgetDeviceRequest request, AmazonServiceCallback<AdminForgetDeviceRequest, AdminForgetDeviceResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminGetDevice


        /// <summary>
        /// Initiates the asynchronous execution of the AdminGetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminGetDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetDevice">REST API Reference for AdminGetDevice Operation</seealso>
        void AdminGetDeviceAsync(AdminGetDeviceRequest request, AmazonServiceCallback<AdminGetDeviceRequest, AdminGetDeviceResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminGetUser


        /// <summary>
        /// Initiates the asynchronous execution of the AdminGetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminGetUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetUser">REST API Reference for AdminGetUser Operation</seealso>
        void AdminGetUserAsync(AdminGetUserRequest request, AmazonServiceCallback<AdminGetUserRequest, AdminGetUserResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminInitiateAuth


        /// <summary>
        /// Initiates the asynchronous execution of the AdminInitiateAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminInitiateAuth operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminInitiateAuth">REST API Reference for AdminInitiateAuth Operation</seealso>
        void AdminInitiateAuthAsync(AdminInitiateAuthRequest request, AmazonServiceCallback<AdminInitiateAuthRequest, AdminInitiateAuthResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminLinkProviderForUser


        /// <summary>
        /// Initiates the asynchronous execution of the AdminLinkProviderForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminLinkProviderForUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminLinkProviderForUser">REST API Reference for AdminLinkProviderForUser Operation</seealso>
        void AdminLinkProviderForUserAsync(AdminLinkProviderForUserRequest request, AmazonServiceCallback<AdminLinkProviderForUserRequest, AdminLinkProviderForUserResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminListDevices


        /// <summary>
        /// Initiates the asynchronous execution of the AdminListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminListDevices operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListDevices">REST API Reference for AdminListDevices Operation</seealso>
        void AdminListDevicesAsync(AdminListDevicesRequest request, AmazonServiceCallback<AdminListDevicesRequest, AdminListDevicesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminListGroupsForUser


        /// <summary>
        /// Initiates the asynchronous execution of the AdminListGroupsForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminListGroupsForUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListGroupsForUser">REST API Reference for AdminListGroupsForUser Operation</seealso>
        void AdminListGroupsForUserAsync(AdminListGroupsForUserRequest request, AmazonServiceCallback<AdminListGroupsForUserRequest, AdminListGroupsForUserResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminListUserAuthEvents


        /// <summary>
        /// Initiates the asynchronous execution of the AdminListUserAuthEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminListUserAuthEvents operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListUserAuthEvents">REST API Reference for AdminListUserAuthEvents Operation</seealso>
        void AdminListUserAuthEventsAsync(AdminListUserAuthEventsRequest request, AmazonServiceCallback<AdminListUserAuthEventsRequest, AdminListUserAuthEventsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminRemoveUserFromGroup


        /// <summary>
        /// Initiates the asynchronous execution of the AdminRemoveUserFromGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminRemoveUserFromGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRemoveUserFromGroup">REST API Reference for AdminRemoveUserFromGroup Operation</seealso>
        void AdminRemoveUserFromGroupAsync(AdminRemoveUserFromGroupRequest request, AmazonServiceCallback<AdminRemoveUserFromGroupRequest, AdminRemoveUserFromGroupResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminResetUserPassword


        /// <summary>
        /// Initiates the asynchronous execution of the AdminResetUserPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminResetUserPassword operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminResetUserPassword">REST API Reference for AdminResetUserPassword Operation</seealso>
        void AdminResetUserPasswordAsync(AdminResetUserPasswordRequest request, AmazonServiceCallback<AdminResetUserPasswordRequest, AdminResetUserPasswordResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminRespondToAuthChallenge


        /// <summary>
        /// Initiates the asynchronous execution of the AdminRespondToAuthChallenge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminRespondToAuthChallenge operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRespondToAuthChallenge">REST API Reference for AdminRespondToAuthChallenge Operation</seealso>
        void AdminRespondToAuthChallengeAsync(AdminRespondToAuthChallengeRequest request, AmazonServiceCallback<AdminRespondToAuthChallengeRequest, AdminRespondToAuthChallengeResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminSetUserMFAPreference


        /// <summary>
        /// Initiates the asynchronous execution of the AdminSetUserMFAPreference operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserMFAPreference operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserMFAPreference">REST API Reference for AdminSetUserMFAPreference Operation</seealso>
        void AdminSetUserMFAPreferenceAsync(AdminSetUserMFAPreferenceRequest request, AmazonServiceCallback<AdminSetUserMFAPreferenceRequest, AdminSetUserMFAPreferenceResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminSetUserSettings


        /// <summary>
        /// Initiates the asynchronous execution of the AdminSetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserSettings operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserSettings">REST API Reference for AdminSetUserSettings Operation</seealso>
        void AdminSetUserSettingsAsync(AdminSetUserSettingsRequest request, AmazonServiceCallback<AdminSetUserSettingsRequest, AdminSetUserSettingsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminUpdateAuthEventFeedback


        /// <summary>
        /// Initiates the asynchronous execution of the AdminUpdateAuthEventFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateAuthEventFeedback operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateAuthEventFeedback">REST API Reference for AdminUpdateAuthEventFeedback Operation</seealso>
        void AdminUpdateAuthEventFeedbackAsync(AdminUpdateAuthEventFeedbackRequest request, AmazonServiceCallback<AdminUpdateAuthEventFeedbackRequest, AdminUpdateAuthEventFeedbackResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminUpdateDeviceStatus


        /// <summary>
        /// Initiates the asynchronous execution of the AdminUpdateDeviceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateDeviceStatus operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateDeviceStatus">REST API Reference for AdminUpdateDeviceStatus Operation</seealso>
        void AdminUpdateDeviceStatusAsync(AdminUpdateDeviceStatusRequest request, AmazonServiceCallback<AdminUpdateDeviceStatusRequest, AdminUpdateDeviceStatusResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminUpdateUserAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the AdminUpdateUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateUserAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateUserAttributes">REST API Reference for AdminUpdateUserAttributes Operation</seealso>
        void AdminUpdateUserAttributesAsync(AdminUpdateUserAttributesRequest request, AmazonServiceCallback<AdminUpdateUserAttributesRequest, AdminUpdateUserAttributesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AdminUserGlobalSignOut


        /// <summary>
        /// Initiates the asynchronous execution of the AdminUserGlobalSignOut operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUserGlobalSignOut operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUserGlobalSignOut">REST API Reference for AdminUserGlobalSignOut Operation</seealso>
        void AdminUserGlobalSignOutAsync(AdminUserGlobalSignOutRequest request, AmazonServiceCallback<AdminUserGlobalSignOutRequest, AdminUserGlobalSignOutResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AssociateSoftwareToken


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSoftwareToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSoftwareToken operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AssociateSoftwareToken">REST API Reference for AssociateSoftwareToken Operation</seealso>
        void AssociateSoftwareTokenAsync(AssociateSoftwareTokenRequest request, AmazonServiceCallback<AssociateSoftwareTokenRequest, AssociateSoftwareTokenResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ChangePassword


        /// <summary>
        /// Initiates the asynchronous execution of the ChangePassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ChangePassword">REST API Reference for ChangePassword Operation</seealso>
        void ChangePasswordAsync(ChangePasswordRequest request, AmazonServiceCallback<ChangePasswordRequest, ChangePasswordResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ConfirmDevice


        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmDevice">REST API Reference for ConfirmDevice Operation</seealso>
        void ConfirmDeviceAsync(ConfirmDeviceRequest request, AmazonServiceCallback<ConfirmDeviceRequest, ConfirmDeviceResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ConfirmForgotPassword


        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmForgotPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmForgotPassword operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmForgotPassword">REST API Reference for ConfirmForgotPassword Operation</seealso>
        void ConfirmForgotPasswordAsync(ConfirmForgotPasswordRequest request, AmazonServiceCallback<ConfirmForgotPasswordRequest, ConfirmForgotPasswordResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ConfirmSignUp


        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmSignUp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmSignUp operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmSignUp">REST API Reference for ConfirmSignUp Operation</seealso>
        void ConfirmSignUpAsync(ConfirmSignUpRequest request, AmazonServiceCallback<ConfirmSignUpRequest, ConfirmSignUpResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        void CreateGroupAsync(CreateGroupRequest request, AmazonServiceCallback<CreateGroupRequest, CreateGroupResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateIdentityProvider


        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityProvider operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateIdentityProvider">REST API Reference for CreateIdentityProvider Operation</seealso>
        void CreateIdentityProviderAsync(CreateIdentityProviderRequest request, AmazonServiceCallback<CreateIdentityProviderRequest, CreateIdentityProviderResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateResourceServer


        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceServer operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateResourceServer">REST API Reference for CreateResourceServer Operation</seealso>
        void CreateResourceServerAsync(CreateResourceServerRequest request, AmazonServiceCallback<CreateResourceServerRequest, CreateResourceServerResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateUserImportJob


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserImportJob operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserImportJob">REST API Reference for CreateUserImportJob Operation</seealso>
        void CreateUserImportJobAsync(CreateUserImportJobRequest request, AmazonServiceCallback<CreateUserImportJobRequest, CreateUserImportJobResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateUserPool


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPool operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPool">REST API Reference for CreateUserPool Operation</seealso>
        void CreateUserPoolAsync(CreateUserPoolRequest request, AmazonServiceCallback<CreateUserPoolRequest, CreateUserPoolResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateUserPoolClient


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPoolClient operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolClient">REST API Reference for CreateUserPoolClient Operation</seealso>
        void CreateUserPoolClientAsync(CreateUserPoolClientRequest request, AmazonServiceCallback<CreateUserPoolClientRequest, CreateUserPoolClientResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateUserPoolDomain


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPoolDomain operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolDomain">REST API Reference for CreateUserPoolDomain Operation</seealso>
        void CreateUserPoolDomainAsync(CreateUserPoolDomainRequest request, AmazonServiceCallback<CreateUserPoolDomainRequest, CreateUserPoolDomainResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        void DeleteGroupAsync(DeleteGroupRequest request, AmazonServiceCallback<DeleteGroupRequest, DeleteGroupResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteIdentityProvider


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityProvider operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteIdentityProvider">REST API Reference for DeleteIdentityProvider Operation</seealso>
        void DeleteIdentityProviderAsync(DeleteIdentityProviderRequest request, AmazonServiceCallback<DeleteIdentityProviderRequest, DeleteIdentityProviderResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteResourceServer


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceServer operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteResourceServer">REST API Reference for DeleteResourceServer Operation</seealso>
        void DeleteResourceServerAsync(DeleteResourceServerRequest request, AmazonServiceCallback<DeleteResourceServerRequest, DeleteResourceServerResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        void DeleteUserAsync(DeleteUserRequest request, AmazonServiceCallback<DeleteUserRequest, DeleteUserResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteUserAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserAttributes">REST API Reference for DeleteUserAttributes Operation</seealso>
        void DeleteUserAttributesAsync(DeleteUserAttributesRequest request, AmazonServiceCallback<DeleteUserAttributesRequest, DeleteUserAttributesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteUserPool


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPool operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPool">REST API Reference for DeleteUserPool Operation</seealso>
        void DeleteUserPoolAsync(DeleteUserPoolRequest request, AmazonServiceCallback<DeleteUserPoolRequest, DeleteUserPoolResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteUserPoolClient


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPoolClient operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolClient">REST API Reference for DeleteUserPoolClient Operation</seealso>
        void DeleteUserPoolClientAsync(DeleteUserPoolClientRequest request, AmazonServiceCallback<DeleteUserPoolClientRequest, DeleteUserPoolClientResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteUserPoolDomain


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPoolDomain operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolDomain">REST API Reference for DeleteUserPoolDomain Operation</seealso>
        void DeleteUserPoolDomainAsync(DeleteUserPoolDomainRequest request, AmazonServiceCallback<DeleteUserPoolDomainRequest, DeleteUserPoolDomainResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DescribeIdentityProvider


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityProvider operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeIdentityProvider">REST API Reference for DescribeIdentityProvider Operation</seealso>
        void DescribeIdentityProviderAsync(DescribeIdentityProviderRequest request, AmazonServiceCallback<DescribeIdentityProviderRequest, DescribeIdentityProviderResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DescribeResourceServer


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceServer operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeResourceServer">REST API Reference for DescribeResourceServer Operation</seealso>
        void DescribeResourceServerAsync(DescribeResourceServerRequest request, AmazonServiceCallback<DescribeResourceServerRequest, DescribeResourceServerResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DescribeRiskConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRiskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRiskConfiguration operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeRiskConfiguration">REST API Reference for DescribeRiskConfiguration Operation</seealso>
        void DescribeRiskConfigurationAsync(DescribeRiskConfigurationRequest request, AmazonServiceCallback<DescribeRiskConfigurationRequest, DescribeRiskConfigurationResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DescribeUserImportJob


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserImportJob operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserImportJob">REST API Reference for DescribeUserImportJob Operation</seealso>
        void DescribeUserImportJobAsync(DescribeUserImportJobRequest request, AmazonServiceCallback<DescribeUserImportJobRequest, DescribeUserImportJobResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DescribeUserPool


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPool operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPool">REST API Reference for DescribeUserPool Operation</seealso>
        void DescribeUserPoolAsync(DescribeUserPoolRequest request, AmazonServiceCallback<DescribeUserPoolRequest, DescribeUserPoolResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DescribeUserPoolClient


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPoolClient operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolClient">REST API Reference for DescribeUserPoolClient Operation</seealso>
        void DescribeUserPoolClientAsync(DescribeUserPoolClientRequest request, AmazonServiceCallback<DescribeUserPoolClientRequest, DescribeUserPoolClientResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DescribeUserPoolDomain


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPoolDomain operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolDomain">REST API Reference for DescribeUserPoolDomain Operation</seealso>
        void DescribeUserPoolDomainAsync(DescribeUserPoolDomainRequest request, AmazonServiceCallback<DescribeUserPoolDomainRequest, DescribeUserPoolDomainResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ForgetDevice


        /// <summary>
        /// Initiates the asynchronous execution of the ForgetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ForgetDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgetDevice">REST API Reference for ForgetDevice Operation</seealso>
        void ForgetDeviceAsync(ForgetDeviceRequest request, AmazonServiceCallback<ForgetDeviceRequest, ForgetDeviceResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ForgotPassword


        /// <summary>
        /// Initiates the asynchronous execution of the ForgotPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ForgotPassword operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgotPassword">REST API Reference for ForgotPassword Operation</seealso>
        void ForgotPasswordAsync(ForgotPasswordRequest request, AmazonServiceCallback<ForgotPasswordRequest, ForgotPasswordResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetCSVHeader


        /// <summary>
        /// Initiates the asynchronous execution of the GetCSVHeader operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCSVHeader operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetCSVHeader">REST API Reference for GetCSVHeader Operation</seealso>
        void GetCSVHeaderAsync(GetCSVHeaderRequest request, AmazonServiceCallback<GetCSVHeaderRequest, GetCSVHeaderResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetDevice


        /// <summary>
        /// Initiates the asynchronous execution of the GetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetDevice">REST API Reference for GetDevice Operation</seealso>
        void GetDeviceAsync(GetDeviceRequest request, AmazonServiceCallback<GetDeviceRequest, GetDeviceResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetGroup


        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetGroup">REST API Reference for GetGroup Operation</seealso>
        void GetGroupAsync(GetGroupRequest request, AmazonServiceCallback<GetGroupRequest, GetGroupResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetIdentityProviderByIdentifier


        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityProviderByIdentifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityProviderByIdentifier operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetIdentityProviderByIdentifier">REST API Reference for GetIdentityProviderByIdentifier Operation</seealso>
        void GetIdentityProviderByIdentifierAsync(GetIdentityProviderByIdentifierRequest request, AmazonServiceCallback<GetIdentityProviderByIdentifierRequest, GetIdentityProviderByIdentifierResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetSigningCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the GetSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSigningCertificate operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetSigningCertificate">REST API Reference for GetSigningCertificate Operation</seealso>
        void GetSigningCertificateAsync(GetSigningCertificateRequest request, AmazonServiceCallback<GetSigningCertificateRequest, GetSigningCertificateResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetUICustomization


        /// <summary>
        /// Initiates the asynchronous execution of the GetUICustomization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUICustomization operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUICustomization">REST API Reference for GetUICustomization Operation</seealso>
        void GetUICustomizationAsync(GetUICustomizationRequest request, AmazonServiceCallback<GetUICustomizationRequest, GetUICustomizationResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetUser


        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUser">REST API Reference for GetUser Operation</seealso>
        void GetUserAsync(GetUserRequest request, AmazonServiceCallback<GetUserRequest, GetUserResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetUserAttributeVerificationCode


        /// <summary>
        /// Initiates the asynchronous execution of the GetUserAttributeVerificationCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserAttributeVerificationCode operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserAttributeVerificationCode">REST API Reference for GetUserAttributeVerificationCode Operation</seealso>
        void GetUserAttributeVerificationCodeAsync(GetUserAttributeVerificationCodeRequest request, AmazonServiceCallback<GetUserAttributeVerificationCodeRequest, GetUserAttributeVerificationCodeResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetUserPoolMfaConfig


        /// <summary>
        /// Initiates the asynchronous execution of the GetUserPoolMfaConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserPoolMfaConfig operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserPoolMfaConfig">REST API Reference for GetUserPoolMfaConfig Operation</seealso>
        void GetUserPoolMfaConfigAsync(GetUserPoolMfaConfigRequest request, AmazonServiceCallback<GetUserPoolMfaConfigRequest, GetUserPoolMfaConfigResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GlobalSignOut


        /// <summary>
        /// Initiates the asynchronous execution of the GlobalSignOut operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GlobalSignOut operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GlobalSignOut">REST API Reference for GlobalSignOut Operation</seealso>
        void GlobalSignOutAsync(GlobalSignOutRequest request, AmazonServiceCallback<GlobalSignOutRequest, GlobalSignOutResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  InitiateAuth


        /// <summary>
        /// Initiates the asynchronous execution of the InitiateAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateAuth operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/InitiateAuth">REST API Reference for InitiateAuth Operation</seealso>
        void InitiateAuthAsync(InitiateAuthRequest request, AmazonServiceCallback<InitiateAuthRequest, InitiateAuthResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListDevices


        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListDevices">REST API Reference for ListDevices Operation</seealso>
        void ListDevicesAsync(ListDevicesRequest request, AmazonServiceCallback<ListDevicesRequest, ListDevicesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListGroups


        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListGroups">REST API Reference for ListGroups Operation</seealso>
        void ListGroupsAsync(ListGroupsRequest request, AmazonServiceCallback<ListGroupsRequest, ListGroupsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListIdentityProviders


        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviders operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        void ListIdentityProvidersAsync(ListIdentityProvidersRequest request, AmazonServiceCallback<ListIdentityProvidersRequest, ListIdentityProvidersResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListResourceServers


        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceServers operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListResourceServers">REST API Reference for ListResourceServers Operation</seealso>
        void ListResourceServersAsync(ListResourceServersRequest request, AmazonServiceCallback<ListResourceServersRequest, ListResourceServersResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        void ListTagsForResourceAsync(ListTagsForResourceRequest request, AmazonServiceCallback<ListTagsForResourceRequest, ListTagsForResourceResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListUserImportJobs


        /// <summary>
        /// Initiates the asynchronous execution of the ListUserImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserImportJobs operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserImportJobs">REST API Reference for ListUserImportJobs Operation</seealso>
        void ListUserImportJobsAsync(ListUserImportJobsRequest request, AmazonServiceCallback<ListUserImportJobsRequest, ListUserImportJobsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListUserPoolClients


        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPoolClients operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserPoolClients operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPoolClients">REST API Reference for ListUserPoolClients Operation</seealso>
        void ListUserPoolClientsAsync(ListUserPoolClientsRequest request, AmazonServiceCallback<ListUserPoolClientsRequest, ListUserPoolClientsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListUserPools


        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserPools operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPools">REST API Reference for ListUserPools Operation</seealso>
        void ListUserPoolsAsync(ListUserPoolsRequest request, AmazonServiceCallback<ListUserPoolsRequest, ListUserPoolsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListUsers


        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsers">REST API Reference for ListUsers Operation</seealso>
        void ListUsersAsync(ListUsersRequest request, AmazonServiceCallback<ListUsersRequest, ListUsersResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListUsersInGroup


        /// <summary>
        /// Initiates the asynchronous execution of the ListUsersInGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsersInGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsersInGroup">REST API Reference for ListUsersInGroup Operation</seealso>
        void ListUsersInGroupAsync(ListUsersInGroupRequest request, AmazonServiceCallback<ListUsersInGroupRequest, ListUsersInGroupResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ResendConfirmationCode


        /// <summary>
        /// Initiates the asynchronous execution of the ResendConfirmationCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResendConfirmationCode operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ResendConfirmationCode">REST API Reference for ResendConfirmationCode Operation</seealso>
        void ResendConfirmationCodeAsync(ResendConfirmationCodeRequest request, AmazonServiceCallback<ResendConfirmationCodeRequest, ResendConfirmationCodeResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  RespondToAuthChallenge


        /// <summary>
        /// Initiates the asynchronous execution of the RespondToAuthChallenge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondToAuthChallenge operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/RespondToAuthChallenge">REST API Reference for RespondToAuthChallenge Operation</seealso>
        void RespondToAuthChallengeAsync(RespondToAuthChallengeRequest request, AmazonServiceCallback<RespondToAuthChallengeRequest, RespondToAuthChallengeResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  SetRiskConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the SetRiskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetRiskConfiguration operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetRiskConfiguration">REST API Reference for SetRiskConfiguration Operation</seealso>
        void SetRiskConfigurationAsync(SetRiskConfigurationRequest request, AmazonServiceCallback<SetRiskConfigurationRequest, SetRiskConfigurationResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  SetUICustomization


        /// <summary>
        /// Initiates the asynchronous execution of the SetUICustomization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUICustomization operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUICustomization">REST API Reference for SetUICustomization Operation</seealso>
        void SetUICustomizationAsync(SetUICustomizationRequest request, AmazonServiceCallback<SetUICustomizationRequest, SetUICustomizationResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  SetUserMFAPreference


        /// <summary>
        /// Initiates the asynchronous execution of the SetUserMFAPreference operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUserMFAPreference operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserMFAPreference">REST API Reference for SetUserMFAPreference Operation</seealso>
        void SetUserMFAPreferenceAsync(SetUserMFAPreferenceRequest request, AmazonServiceCallback<SetUserMFAPreferenceRequest, SetUserMFAPreferenceResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  SetUserPoolMfaConfig


        /// <summary>
        /// Initiates the asynchronous execution of the SetUserPoolMfaConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUserPoolMfaConfig operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserPoolMfaConfig">REST API Reference for SetUserPoolMfaConfig Operation</seealso>
        void SetUserPoolMfaConfigAsync(SetUserPoolMfaConfigRequest request, AmazonServiceCallback<SetUserPoolMfaConfigRequest, SetUserPoolMfaConfigResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  SetUserSettings


        /// <summary>
        /// Initiates the asynchronous execution of the SetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUserSettings operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserSettings">REST API Reference for SetUserSettings Operation</seealso>
        void SetUserSettingsAsync(SetUserSettingsRequest request, AmazonServiceCallback<SetUserSettingsRequest, SetUserSettingsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  SignUp


        /// <summary>
        /// Initiates the asynchronous execution of the SignUp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignUp operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SignUp">REST API Reference for SignUp Operation</seealso>
        void SignUpAsync(SignUpRequest request, AmazonServiceCallback<SignUpRequest, SignUpResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  StartUserImportJob


        /// <summary>
        /// Initiates the asynchronous execution of the StartUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartUserImportJob operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StartUserImportJob">REST API Reference for StartUserImportJob Operation</seealso>
        void StartUserImportJobAsync(StartUserImportJobRequest request, AmazonServiceCallback<StartUserImportJobRequest, StartUserImportJobResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  StopUserImportJob


        /// <summary>
        /// Initiates the asynchronous execution of the StopUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopUserImportJob operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StopUserImportJob">REST API Reference for StopUserImportJob Operation</seealso>
        void StopUserImportJobAsync(StopUserImportJobRequest request, AmazonServiceCallback<StopUserImportJobRequest, StopUserImportJobResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  TagResource


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/TagResource">REST API Reference for TagResource Operation</seealso>
        void TagResourceAsync(TagResourceRequest request, AmazonServiceCallback<TagResourceRequest, TagResourceResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        void UntagResourceAsync(UntagResourceRequest request, AmazonServiceCallback<UntagResourceRequest, UntagResourceResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateAuthEventFeedback


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAuthEventFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthEventFeedback operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateAuthEventFeedback">REST API Reference for UpdateAuthEventFeedback Operation</seealso>
        void UpdateAuthEventFeedbackAsync(UpdateAuthEventFeedbackRequest request, AmazonServiceCallback<UpdateAuthEventFeedbackRequest, UpdateAuthEventFeedbackResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateDeviceStatus


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeviceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceStatus operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateDeviceStatus">REST API Reference for UpdateDeviceStatus Operation</seealso>
        void UpdateDeviceStatusAsync(UpdateDeviceStatusRequest request, AmazonServiceCallback<UpdateDeviceStatusRequest, UpdateDeviceStatusResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateGroup


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        void UpdateGroupAsync(UpdateGroupRequest request, AmazonServiceCallback<UpdateGroupRequest, UpdateGroupResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateIdentityProvider


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProvider operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateIdentityProvider">REST API Reference for UpdateIdentityProvider Operation</seealso>
        void UpdateIdentityProviderAsync(UpdateIdentityProviderRequest request, AmazonServiceCallback<UpdateIdentityProviderRequest, UpdateIdentityProviderResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateResourceServer


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceServer operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateResourceServer">REST API Reference for UpdateResourceServer Operation</seealso>
        void UpdateResourceServerAsync(UpdateResourceServerRequest request, AmazonServiceCallback<UpdateResourceServerRequest, UpdateResourceServerResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateUserAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserAttributes">REST API Reference for UpdateUserAttributes Operation</seealso>
        void UpdateUserAttributesAsync(UpdateUserAttributesRequest request, AmazonServiceCallback<UpdateUserAttributesRequest, UpdateUserAttributesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateUserPool


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPool operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPool">REST API Reference for UpdateUserPool Operation</seealso>
        void UpdateUserPoolAsync(UpdateUserPoolRequest request, AmazonServiceCallback<UpdateUserPoolRequest, UpdateUserPoolResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateUserPoolClient


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPoolClient operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolClient">REST API Reference for UpdateUserPoolClient Operation</seealso>
        void UpdateUserPoolClientAsync(UpdateUserPoolClientRequest request, AmazonServiceCallback<UpdateUserPoolClientRequest, UpdateUserPoolClientResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateUserPoolDomain


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPoolDomain operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolDomain">REST API Reference for UpdateUserPoolDomain Operation</seealso>
        void UpdateUserPoolDomainAsync(UpdateUserPoolDomainRequest request, AmazonServiceCallback<UpdateUserPoolDomainRequest, UpdateUserPoolDomainResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  VerifySoftwareToken


        /// <summary>
        /// Initiates the asynchronous execution of the VerifySoftwareToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifySoftwareToken operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifySoftwareToken">REST API Reference for VerifySoftwareToken Operation</seealso>
        void VerifySoftwareTokenAsync(VerifySoftwareTokenRequest request, AmazonServiceCallback<VerifySoftwareTokenRequest, VerifySoftwareTokenResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  VerifyUserAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the VerifyUserAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyUserAttribute operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifyUserAttribute">REST API Reference for VerifyUserAttribute Operation</seealso>
        void VerifyUserAttributeAsync(VerifyUserAttributeRequest request, AmazonServiceCallback<VerifyUserAttributeRequest, VerifyUserAttributeResponse> callback, AsyncOptions options = null);


        #endregion
        
    }
}