﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.ServiceFabric.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.ServiceFabric.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Insecure cluster {0} is not allowed to add certificate..
        /// </summary>
        internal static string AddCertToUnsecureCluster {
            get {
                return ResourceManager.GetString("AddCertToUnsecureCluster", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot change durability level from {0} to {1}..
        /// </summary>
        internal static string CannotChangeDurabilityFrom {
            get {
                return ResourceManager.GetString("CannotChangeDurabilityFrom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot delete primary node type {0}..
        /// </summary>
        internal static string CannotDeletePrimaryNodeType {
            get {
                return ResourceManager.GetString("CannotDeletePrimaryNodeType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find the certificate {0} in the cluster..
        /// </summary>
        internal static string CannotFindCertificateInCluster {
            get {
                return ResourceManager.GetString("CannotFindCertificateInCluster", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find the common name {0} and issuer {1} in the cluster..
        /// </summary>
        internal static string CannotFindCommonNameAndIssuer {
            get {
                return ResourceManager.GetString("CannotFindCommonNameAndIssuer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find durability level setting..
        /// </summary>
        internal static string CannotFindDurabilityLevelSetting {
            get {
                return ResourceManager.GetString("CannotFindDurabilityLevelSetting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find tenant Id..
        /// </summary>
        internal static string CannotFindTenantId {
            get {
                return ResourceManager.GetString("CannotFindTenantId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find the node type {0}..
        /// </summary>
        internal static string CannotFindTheNodeType {
            get {
                return ResourceManager.GetString("CannotFindTheNodeType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find the thumbprint {0} in the cluster..
        /// </summary>
        internal static string CannotFindThumbprintInTheCluster {
            get {
                return ResourceManager.GetString("CannotFindThumbprintInTheCluster", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find key vault {0}..
        /// </summary>
        internal static string CannotFindVault {
            get {
                return ResourceManager.GetString("CannotFindVault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find key vault &apos;{0}&apos; from secret id &apos;{1}&apos;..
        /// </summary>
        internal static string CannotFindVaultFromSecretId {
            get {
                return ResourceManager.GetString("CannotFindVaultFromSecretId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot parse reliability level {0}..
        /// </summary>
        internal static string CannotParseReliabilityLevel {
            get {
                return ResourceManager.GetString("CannotParseReliabilityLevel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot update node type with a durability level of Bronze, please update durability level to Silver or above first..
        /// </summary>
        internal static string CannotUpdateBronzeNodeType {
            get {
                return ResourceManager.GetString("CannotUpdateBronzeNodeType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot update node count to {0} because it is less than the minimum required node count of {1} for {2} reliability level..
        /// </summary>
        internal static string CannotUpdateNodeCountLessThenReliabilityLevel {
            get {
                return ResourceManager.GetString("CannotUpdateNodeCountLessThenReliabilityLevel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot update Sku while durability level is Bronze, please update durability level to Silver or above first..
        /// </summary>
        internal static string CannotUpdateSkuWithBronzeDurability {
            get {
                return ResourceManager.GetString("CannotUpdateSkuWithBronzeDurability", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Checking deployment status in {0} seconds..
        /// </summary>
        internal static string CheckingDeploymentStatus {
            get {
                return ResourceManager.GetString("CheckingDeploymentStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The state of the cluster is : {0}..
        /// </summary>
        internal static string ClusterStateVerbose {
            get {
                return ResourceManager.GetString("ClusterStateVerbose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create self signed certificate failed with Status: {0}, StatusDetails: {1}, Code: {2}, Message: {3}..
        /// </summary>
        internal static string CreateSelfSignedCertificateFailedWithErrorDetail {
            get {
                return ResourceManager.GetString("CreateSelfSignedCertificateFailedWithErrorDetail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create self signed certificate failed with Status: {0}, StatusDetails: {1}..
        /// </summary>
        internal static string CreateSelfSignedCertificateFailedWithoutErrorDetail {
            get {
                return ResourceManager.GetString("CreateSelfSignedCertificateFailedWithoutErrorDetail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating self signed certificate timeout..
        /// </summary>
        internal static string CreateSelfSignedCertificateTimeout {
            get {
                return ResourceManager.GetString("CreateSelfSignedCertificateTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment failed..
        /// </summary>
        internal static string DeploymentFailed {
            get {
                return ResourceManager.GetString("DeploymentFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment succeeded..
        /// </summary>
        internal static string DeploymentSucceeded {
            get {
                return ResourceManager.GetString("DeploymentSucceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment is running..
        /// </summary>
        internal static string DeploymentVerbose {
            get {
                return ResourceManager.GetString("DeploymentVerbose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Contains duplicate fabric setting {0}..
        /// </summary>
        internal static string DuplicatedFabricSetting {
            get {
                return ResourceManager.GetString("DuplicatedFabricSetting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The durability level is mismatched between the cluster and the VM extension..
        /// </summary>
        internal static string DurabilityLevelMismatches {
            get {
                return ResourceManager.GetString("DurabilityLevelMismatches", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The fabric setting &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string FabricSettingNotFound {
            get {
                return ResourceManager.GetString("FabricSettingNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create self signed certificate..
        /// </summary>
        internal static string FailedToCreateSelfSignedCertificate {
            get {
                return ResourceManager.GetString("FailedToCreateSelfSignedCertificate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create the storage account..
        /// </summary>
        internal static string FailedToCreateStorageAccount {
            get {
                return ResourceManager.GetString("FailedToCreateStorageAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Did not find the primary node type in cluster {0}..
        /// </summary>
        internal static string FailedToFindPrimaryNodeTypeError {
            get {
                return ResourceManager.GetString("FailedToFindPrimaryNodeTypeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to parse parameter file..
        /// </summary>
        internal static string FailedToParseParameterFile {
            get {
                return ResourceManager.GetString("FailedToParseParameterFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to parse template file..
        /// </summary>
        internal static string FailedToParseTemplateFile {
            get {
                return ResourceManager.GetString("FailedToParseTemplateFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File {0} doesn&apos;t exist..
        /// </summary>
        internal static string FileNotExist {
            get {
                return ResourceManager.GetString("FileNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The primary certificate parameter names in the parameters file should be specified with &apos;sourceVaultValue&apos;,&apos;certificateThumbprint&apos;,&apos;certificateUrlValue&apos;. If the secondary certificate parameters are specified in the parameters file, the parameter names should be specified with &apos;secSourceVaultValue&apos;,&apos;secCertificateThumbprint&apos;,&apos;secCertificateUrlValue&apos;..
        /// </summary>
        internal static string InvalidCertificateInformationInParameterFile {
            get {
                return ResourceManager.GetString("InvalidCertificateInformationInParameterFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directory {0} doesn&apos;t exist..
        /// </summary>
        internal static string InvalidDirectory {
            get {
                return ResourceManager.GetString("InvalidDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File name {0} contains invalid characters..
        /// </summary>
        internal static string InvalidFileName {
            get {
                return ResourceManager.GetString("InvalidFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid input..
        /// </summary>
        internal static string InvalidInput {
            get {
                return ResourceManager.GetString("InvalidInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid virtual network name in resource ID: {0}..
        /// </summary>
        internal static string InvalidNetworkNameInResourceId {
            get {
                return ResourceManager.GetString("InvalidNetworkNameInResourceId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The supplied password must be between 12-123 characters long and must satisfy at least 3 of the password complexity requirements from the following: \r\n1) Contains an uppercase character\r\n2) Contains a lowercase character\r\n3) Contains a numeric digit\r\n4) Contains a special character..
        /// </summary>
        internal static string InvalidPassword {
            get {
                return ResourceManager.GetString("InvalidPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid template file..
        /// </summary>
        internal static string InvalidTemplateFile {
            get {
                return ResourceManager.GetString("InvalidTemplateFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid template parameter file..
        /// </summary>
        internal static string InvalidTemplateParameterFile {
            get {
                return ResourceManager.GetString("InvalidTemplateParameterFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid existing VMSS configuration..
        /// </summary>
        internal static string InvalidVmssConfiguration {
            get {
                return ResourceManager.GetString("InvalidVmssConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid existing VMSS IP configuration..
        /// </summary>
        internal static string InvalidVmssIpConfiguration {
            get {
                return ResourceManager.GetString("InvalidVmssIpConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid existing VMSS network configuration..
        /// </summary>
        internal static string InvalidVmssNetworkConfiguration {
            get {
                return ResourceManager.GetString("InvalidVmssNetworkConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The key vault and the resource group are not in the same region..
        /// </summary>
        internal static string KeyVaultAndResourceGroupNotSameRegion {
            get {
                return ResourceManager.GetString("KeyVaultAndResourceGroupNotSameRegion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cluster {0} already exists. Please remove the resource group and try again..
        /// </summary>
        internal static string NewExistingCluster {
            get {
                return ResourceManager.GetString("NewExistingCluster", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No certificateOperation returned when creating self signed certificate in Azure key vault..
        /// </summary>
        internal static string NoCertificateOperationReturned {
            get {
                return ResourceManager.GetString("NoCertificateOperationReturned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Did not find any certificate in the cluster..
        /// </summary>
        internal static string NoneCertificateFound {
            get {
                return ResourceManager.GetString("NoneCertificateFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Did not find any node type in resource group {0}..
        /// </summary>
        internal static string NoneNodeTypeFound {
            get {
                return ResourceManager.GetString("NoneNodeTypeFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is only one certificate in the cluster, which cannot be removed..
        /// </summary>
        internal static string OnlyOneClusterCertificate {
            get {
                return ResourceManager.GetString("OnlyOneClusterCertificate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Insecure cluster {0} is not allowed to remove certificate..
        /// </summary>
        internal static string RemoveCertFromUnsecureCluster {
            get {
                return ResourceManager.GetString("RemoveCertFromUnsecureCluster", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The resource group {0} is not found..
        /// </summary>
        internal static string ResourceGroupNotFound {
            get {
                return ResourceManager.GetString("ResourceGroupNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The capacity of the node type is null..
        /// </summary>
        internal static string SkuCapacityIsNull {
            get {
                return ResourceManager.GetString("SkuCapacityIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The capacity of the node type would be less than zero..
        /// </summary>
        internal static string SkuCapacityZero {
            get {
                return ResourceManager.GetString("SkuCapacityZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only {0} skus support Gold durability. Please specify -VmSku with one of these values..
        /// </summary>
        internal static string UnsupportedVmSkuForGold {
            get {
                return ResourceManager.GetString("UnsupportedVmSkuForGold", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Primary node count is {0}, which is less than the required node count of {1} for the target reliability level. Please use &apos;AutoAddNode&apos; switch to automatically increase node count..
        /// </summary>
        internal static string UseAutoToIncreaseNodesCount {
            get {
                return ResourceManager.GetString("UseAutoToIncreaseNodesCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access policy is not set. No user or application have access permission to use this vault. Please use Set-AzureRmKeyVaultAccessPolicy to set access policies..
        /// </summary>
        internal static string VaultCreatedWithOutAccessPolicy {
            get {
                return ResourceManager.GetString("VaultCreatedWithOutAccessPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The resource group should have a valid VM extension for Service Fabric..
        /// </summary>
        internal static string VmExtensionNotFound {
            get {
                return ResourceManager.GetString("VmExtensionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Virtual machine scale set {0} state is {1}..
        /// </summary>
        internal static string VmssVerbose {
            get {
                return ResourceManager.GetString("VmssVerbose", resourceCulture);
            }
        }
    }
}
