namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LicensemanagerAssociationState<'LicenseConfigurationArn, 'ResourceArn> = { assignments: ResizeArray<aws.LicensemanagerAssociation.LicensemanagerAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_association">aws_licensemanager_association</a>.
    /// </summary>
    type LicensemanagerAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : LicensemanagerAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LicensemanagerAssociationState<Missing, Missing>)

        member _.Zero(()) : LicensemanagerAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LicensemanagerAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_association#license_configuration_arn-1">LicensemanagerAssociation#license_configuration_arn</a>.
        /// </summary>
        [<CustomOperation "license_configuration_arn">]
        member _.LicenseConfigurationArn(state: LicensemanagerAssociationState<Missing, 'ResourceArn>, value: string) : LicensemanagerAssociationState<Present, 'ResourceArn> =
            state.assignments.Add(fun config -> config.LicenseConfigurationArn <- value)
            ({ assignments = state.assignments } : LicensemanagerAssociationState<Present, 'ResourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_association#resource_arn-1">LicensemanagerAssociation#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: LicensemanagerAssociationState<'LicenseConfigurationArn, Missing>, value: string) : LicensemanagerAssociationState<'LicenseConfigurationArn, Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : LicensemanagerAssociationState<'LicenseConfigurationArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_association#id-1">LicensemanagerAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LicensemanagerAssociationState<'LicenseConfigurationArn, 'ResourceArn>, value: string) : LicensemanagerAssociationState<'LicenseConfigurationArn, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LicensemanagerAssociationState<'LicenseConfigurationArn, 'ResourceArn>

        member _.Run(state: LicensemanagerAssociationState<Present, Present>) : aws.LicensemanagerAssociation.LicensemanagerAssociation =
            let config = aws.LicensemanagerAssociation.LicensemanagerAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.LicensemanagerAssociation.LicensemanagerAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.licensemanagerAssociation: missing required arguments. Must call: license_configuration_arn, resource_arn.", 9999, IsError = true)>]
        member _.Run(_: LicensemanagerAssociationState<_, _>) : aws.LicensemanagerAssociation.LicensemanagerAssociation =
            Unchecked.defaultof<aws.LicensemanagerAssociation.LicensemanagerAssociation>
