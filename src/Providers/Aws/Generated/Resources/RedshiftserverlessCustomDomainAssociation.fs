namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftserverlessCustomDomainAssociationState<'CustomDomainCertificateArn, 'CustomDomainName, 'WorkgroupName> = { assignments: ResizeArray<aws.RedshiftserverlessCustomDomainAssociation.RedshiftserverlessCustomDomainAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_custom_domain_association">aws_redshiftserverless_custom_domain_association</a>.
    /// </summary>
    type RedshiftserverlessCustomDomainAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftserverlessCustomDomainAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftserverlessCustomDomainAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : RedshiftserverlessCustomDomainAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftserverlessCustomDomainAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_custom_domain_association#custom_domain_certificate_arn-1">RedshiftserverlessCustomDomainAssociation#custom_domain_certificate_arn</a>.
        /// </summary>
        [<CustomOperation "custom_domain_certificate_arn">]
        member _.CustomDomainCertificateArn(state: RedshiftserverlessCustomDomainAssociationState<Missing, 'CustomDomainName, 'WorkgroupName>, value: string) : RedshiftserverlessCustomDomainAssociationState<Present, 'CustomDomainName, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.CustomDomainCertificateArn <- value)
            ({ assignments = state.assignments } : RedshiftserverlessCustomDomainAssociationState<Present, 'CustomDomainName, 'WorkgroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_custom_domain_association#custom_domain_name-1">RedshiftserverlessCustomDomainAssociation#custom_domain_name</a>.
        /// </summary>
        [<CustomOperation "custom_domain_name">]
        member _.CustomDomainName(state: RedshiftserverlessCustomDomainAssociationState<'CustomDomainCertificateArn, Missing, 'WorkgroupName>, value: string) : RedshiftserverlessCustomDomainAssociationState<'CustomDomainCertificateArn, Present, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.CustomDomainName <- value)
            ({ assignments = state.assignments } : RedshiftserverlessCustomDomainAssociationState<'CustomDomainCertificateArn, Present, 'WorkgroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_custom_domain_association#workgroup_name-1">RedshiftserverlessCustomDomainAssociation#workgroup_name</a>.
        /// </summary>
        [<CustomOperation "workgroup_name">]
        member _.WorkgroupName(state: RedshiftserverlessCustomDomainAssociationState<'CustomDomainCertificateArn, 'CustomDomainName, Missing>, value: string) : RedshiftserverlessCustomDomainAssociationState<'CustomDomainCertificateArn, 'CustomDomainName, Present> =
            state.assignments.Add(fun config -> config.WorkgroupName <- value)
            ({ assignments = state.assignments } : RedshiftserverlessCustomDomainAssociationState<'CustomDomainCertificateArn, 'CustomDomainName, Present>)

        member _.Run(state: RedshiftserverlessCustomDomainAssociationState<Present, Present, Present>) : aws.RedshiftserverlessCustomDomainAssociation.RedshiftserverlessCustomDomainAssociation =
            let config = aws.RedshiftserverlessCustomDomainAssociation.RedshiftserverlessCustomDomainAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftserverlessCustomDomainAssociation.RedshiftserverlessCustomDomainAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftserverlessCustomDomainAssociation: missing required arguments. Must call: custom_domain_certificate_arn, custom_domain_name, workgroup_name.", 9999, IsError = true)>]
        member _.Run(_: RedshiftserverlessCustomDomainAssociationState<_, _, _>) : aws.RedshiftserverlessCustomDomainAssociation.RedshiftserverlessCustomDomainAssociation =
            Unchecked.defaultof<aws.RedshiftserverlessCustomDomainAssociation.RedshiftserverlessCustomDomainAssociation>
