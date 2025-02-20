// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.PowerShell;

    /// <summary>Properties specific to the monitor resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(MonitorPropertiesTypeConverter))]
    public partial class MonitorProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.MonitorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MonitorProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.MonitorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MonitorProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MonitorProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="MonitorProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.MonitorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MonitorProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LogzOrganizationProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationProperty = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzOrganizationProperties) content.GetValueForProperty("LogzOrganizationProperty",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationProperty, Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.LogzOrganizationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfo = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IUserInfo) content.GetValueForProperty("UserInfo",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfo, Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.UserInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("PlanData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanData = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IPlanData) content.GetValueForProperty("PlanData",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanData, Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.PlanDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("MonitoringStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).MonitoringStatus = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.MonitoringStatus?) content.GetValueForProperty("MonitoringStatus",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).MonitoringStatus, Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.MonitoringStatus.CreateFrom);
            }
            if (content.Contains("MarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).MarketplaceSubscriptionStatus = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.MarketplaceSubscriptionStatus?) content.GetValueForProperty("MarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).MarketplaceSubscriptionStatus, Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.MarketplaceSubscriptionStatus.CreateFrom);
            }
            if (content.Contains("LiftrResourceCategory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LiftrResourceCategory = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.LiftrResourceCategories?) content.GetValueForProperty("LiftrResourceCategory",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LiftrResourceCategory, Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.LiftrResourceCategories.CreateFrom);
            }
            if (content.Contains("LiftrResourcePreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LiftrResourcePreference = (int?) content.GetValueForProperty("LiftrResourcePreference",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LiftrResourcePreference, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("LogzOrganizationPropertyCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationPropertyCompanyName = (string) content.GetValueForProperty("LogzOrganizationPropertyCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationPropertyCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("LogzOrganizationPropertyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationPropertyId = (string) content.GetValueForProperty("LogzOrganizationPropertyId",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationPropertyId, global::System.Convert.ToString);
            }
            if (content.Contains("UserInfoFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfoFirstName = (string) content.GetValueForProperty("UserInfoFirstName",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfoFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserInfoLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfoLastName = (string) content.GetValueForProperty("UserInfoLastName",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfoLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserInfoEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfoEmailAddress = (string) content.GetValueForProperty("UserInfoEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfoEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("UserInfoPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfoPhoneNumber = (string) content.GetValueForProperty("UserInfoPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfoPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataUsageType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanDataUsageType = (string) content.GetValueForProperty("PlanDataUsageType",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanDataUsageType, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataBillingCycle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanDataBillingCycle = (string) content.GetValueForProperty("PlanDataBillingCycle",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanDataBillingCycle, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataPlanDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanDataPlanDetail = (string) content.GetValueForProperty("PlanDataPlanDetail",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanDataPlanDetail, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataEffectiveDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanDataEffectiveDate = (global::System.DateTime?) content.GetValueForProperty("PlanDataEffectiveDate",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanDataEffectiveDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LogzOrganizationPropertyEnterpriseAppId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationPropertyEnterpriseAppId = (string) content.GetValueForProperty("LogzOrganizationPropertyEnterpriseAppId",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationPropertyEnterpriseAppId, global::System.Convert.ToString);
            }
            if (content.Contains("LogzOrganizationPropertySingleSignOnUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationPropertySingleSignOnUrl = (string) content.GetValueForProperty("LogzOrganizationPropertySingleSignOnUrl",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationPropertySingleSignOnUrl, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.MonitorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MonitorProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LogzOrganizationProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationProperty = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzOrganizationProperties) content.GetValueForProperty("LogzOrganizationProperty",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationProperty, Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.LogzOrganizationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfo = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IUserInfo) content.GetValueForProperty("UserInfo",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfo, Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.UserInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("PlanData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanData = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IPlanData) content.GetValueForProperty("PlanData",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanData, Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.PlanDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("MonitoringStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).MonitoringStatus = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.MonitoringStatus?) content.GetValueForProperty("MonitoringStatus",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).MonitoringStatus, Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.MonitoringStatus.CreateFrom);
            }
            if (content.Contains("MarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).MarketplaceSubscriptionStatus = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.MarketplaceSubscriptionStatus?) content.GetValueForProperty("MarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).MarketplaceSubscriptionStatus, Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.MarketplaceSubscriptionStatus.CreateFrom);
            }
            if (content.Contains("LiftrResourceCategory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LiftrResourceCategory = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.LiftrResourceCategories?) content.GetValueForProperty("LiftrResourceCategory",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LiftrResourceCategory, Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.LiftrResourceCategories.CreateFrom);
            }
            if (content.Contains("LiftrResourcePreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LiftrResourcePreference = (int?) content.GetValueForProperty("LiftrResourcePreference",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LiftrResourcePreference, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("LogzOrganizationPropertyCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationPropertyCompanyName = (string) content.GetValueForProperty("LogzOrganizationPropertyCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationPropertyCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("LogzOrganizationPropertyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationPropertyId = (string) content.GetValueForProperty("LogzOrganizationPropertyId",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationPropertyId, global::System.Convert.ToString);
            }
            if (content.Contains("UserInfoFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfoFirstName = (string) content.GetValueForProperty("UserInfoFirstName",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfoFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserInfoLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfoLastName = (string) content.GetValueForProperty("UserInfoLastName",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfoLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserInfoEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfoEmailAddress = (string) content.GetValueForProperty("UserInfoEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfoEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("UserInfoPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfoPhoneNumber = (string) content.GetValueForProperty("UserInfoPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).UserInfoPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataUsageType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanDataUsageType = (string) content.GetValueForProperty("PlanDataUsageType",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanDataUsageType, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataBillingCycle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanDataBillingCycle = (string) content.GetValueForProperty("PlanDataBillingCycle",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanDataBillingCycle, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataPlanDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanDataPlanDetail = (string) content.GetValueForProperty("PlanDataPlanDetail",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanDataPlanDetail, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataEffectiveDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanDataEffectiveDate = (global::System.DateTime?) content.GetValueForProperty("PlanDataEffectiveDate",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).PlanDataEffectiveDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LogzOrganizationPropertyEnterpriseAppId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationPropertyEnterpriseAppId = (string) content.GetValueForProperty("LogzOrganizationPropertyEnterpriseAppId",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationPropertyEnterpriseAppId, global::System.Convert.ToString);
            }
            if (content.Contains("LogzOrganizationPropertySingleSignOnUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationPropertySingleSignOnUrl = (string) content.GetValueForProperty("LogzOrganizationPropertySingleSignOnUrl",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitorPropertiesInternal)this).LogzOrganizationPropertySingleSignOnUrl, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Properties specific to the monitor resource.
    [System.ComponentModel.TypeConverter(typeof(MonitorPropertiesTypeConverter))]
    public partial interface IMonitorProperties

    {

    }
}