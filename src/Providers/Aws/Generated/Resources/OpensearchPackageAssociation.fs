namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpensearchPackageAssociationState<'DomainName, 'PackageId> = { assignments: ResizeArray<aws.OpensearchPackageAssociation.OpensearchPackageAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package_association">aws_opensearch_package_association</a>.
    /// </summary>
    type OpensearchPackageAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpensearchPackageAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchPackageAssociationState<Missing, Missing>)

        member _.Zero(()) : OpensearchPackageAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchPackageAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package_association#domain_name-1">OpensearchPackageAssociation#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: OpensearchPackageAssociationState<Missing, 'PackageId>, value: string) : OpensearchPackageAssociationState<Present, 'PackageId> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : OpensearchPackageAssociationState<Present, 'PackageId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package_association#package_id-1">OpensearchPackageAssociation#package_id</a>.
        /// </summary>
        [<CustomOperation "package_id">]
        member _.PackageId(state: OpensearchPackageAssociationState<'DomainName, Missing>, value: string) : OpensearchPackageAssociationState<'DomainName, Present> =
            state.assignments.Add(fun config -> config.PackageId <- value)
            ({ assignments = state.assignments } : OpensearchPackageAssociationState<'DomainName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package_association#id-1">OpensearchPackageAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpensearchPackageAssociationState<'DomainName, 'PackageId>, value: string) : OpensearchPackageAssociationState<'DomainName, 'PackageId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpensearchPackageAssociationState<'DomainName, 'PackageId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package_association#timeouts-1">OpensearchPackageAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OpensearchPackageAssociationState<'DomainName, 'PackageId>, value: aws.OpensearchPackageAssociation.OpensearchPackageAssociationTimeouts) : OpensearchPackageAssociationState<'DomainName, 'PackageId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OpensearchPackageAssociationState<'DomainName, 'PackageId>

        member _.Run(state: OpensearchPackageAssociationState<Present, Present>) : aws.OpensearchPackageAssociation.OpensearchPackageAssociation =
            let config = aws.OpensearchPackageAssociation.OpensearchPackageAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.OpensearchPackageAssociation.OpensearchPackageAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opensearchPackageAssociation: missing required arguments. Must call: domain_name, package_id.", 9999, IsError = true)>]
        member _.Run(_: OpensearchPackageAssociationState<_, _>) : aws.OpensearchPackageAssociation.OpensearchPackageAssociation =
            Unchecked.defaultof<aws.OpensearchPackageAssociation.OpensearchPackageAssociation>
