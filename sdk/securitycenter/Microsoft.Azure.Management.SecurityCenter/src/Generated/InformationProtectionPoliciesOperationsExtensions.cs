// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for InformationProtectionPoliciesOperations.
    /// </summary>
    public static partial class InformationProtectionPoliciesOperationsExtensions
    {
            /// <summary>
            /// Details of the information protection policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query, can be subscription
            /// (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group
            /// (/providers/Microsoft.Management/managementGroups/mgName).
            /// </param>
            /// <param name='informationProtectionPolicyName'>
            /// Name of the information protection policy. Possible values include:
            /// 'effective', 'custom'
            /// </param>
            public static InformationProtectionPolicy Get(this IInformationProtectionPoliciesOperations operations, string scope, string informationProtectionPolicyName)
            {
                return operations.GetAsync(scope, informationProtectionPolicyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Details of the information protection policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query, can be subscription
            /// (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group
            /// (/providers/Microsoft.Management/managementGroups/mgName).
            /// </param>
            /// <param name='informationProtectionPolicyName'>
            /// Name of the information protection policy. Possible values include:
            /// 'effective', 'custom'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InformationProtectionPolicy> GetAsync(this IInformationProtectionPoliciesOperations operations, string scope, string informationProtectionPolicyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(scope, informationProtectionPolicyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Details of the information protection policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query, can be subscription
            /// (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group
            /// (/providers/Microsoft.Management/managementGroups/mgName).
            /// </param>
            /// <param name='informationProtectionPolicyName'>
            /// Name of the information protection policy. Possible values include:
            /// 'effective', 'custom'
            /// </param>
            /// <param name='labels'>
            /// Dictionary of sensitivity labels.
            /// </param>
            /// <param name='informationTypes'>
            /// The sensitivity information types.
            /// </param>
            public static InformationProtectionPolicy CreateOrUpdate(this IInformationProtectionPoliciesOperations operations, string scope, string informationProtectionPolicyName, IDictionary<string, SensitivityLabel> labels = default(IDictionary<string, SensitivityLabel>), IDictionary<string, InformationType> informationTypes = default(IDictionary<string, InformationType>))
            {
                return operations.CreateOrUpdateAsync(scope, informationProtectionPolicyName, labels, informationTypes).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Details of the information protection policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query, can be subscription
            /// (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group
            /// (/providers/Microsoft.Management/managementGroups/mgName).
            /// </param>
            /// <param name='informationProtectionPolicyName'>
            /// Name of the information protection policy. Possible values include:
            /// 'effective', 'custom'
            /// </param>
            /// <param name='labels'>
            /// Dictionary of sensitivity labels.
            /// </param>
            /// <param name='informationTypes'>
            /// The sensitivity information types.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InformationProtectionPolicy> CreateOrUpdateAsync(this IInformationProtectionPoliciesOperations operations, string scope, string informationProtectionPolicyName, IDictionary<string, SensitivityLabel> labels = default(IDictionary<string, SensitivityLabel>), IDictionary<string, InformationType> informationTypes = default(IDictionary<string, InformationType>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(scope, informationProtectionPolicyName, labels, informationTypes, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Information protection policies of a specific management group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query, can be subscription
            /// (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group
            /// (/providers/Microsoft.Management/managementGroups/mgName).
            /// </param>
            public static IPage<InformationProtectionPolicy> List(this IInformationProtectionPoliciesOperations operations, string scope)
            {
                return operations.ListAsync(scope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Information protection policies of a specific management group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query, can be subscription
            /// (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group
            /// (/providers/Microsoft.Management/managementGroups/mgName).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<InformationProtectionPolicy>> ListAsync(this IInformationProtectionPoliciesOperations operations, string scope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(scope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Information protection policies of a specific management group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<InformationProtectionPolicy> ListNext(this IInformationProtectionPoliciesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Information protection policies of a specific management group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<InformationProtectionPolicy>> ListNextAsync(this IInformationProtectionPoliciesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
