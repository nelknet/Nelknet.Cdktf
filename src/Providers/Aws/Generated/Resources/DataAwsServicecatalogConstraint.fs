namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsServicecatalogConstraintState<'Id> = { assignments: ResizeArray<aws.DataAwsServicecatalogConstraint.DataAwsServicecatalogConstraintConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_constraint">aws_servicecatalog_constraint</a>.
    /// </summary>
    type DataAwsServicecatalogConstraintBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsServicecatalogConstraintState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicecatalogConstraintState<Missing>)

        member _.Zero(()) : DataAwsServicecatalogConstraintState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicecatalogConstraintState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_constraint#id-1">DataAwsServicecatalogConstraint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsServicecatalogConstraintState<Missing>, value: string) : DataAwsServicecatalogConstraintState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsServicecatalogConstraintState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_constraint#accept_language-1">DataAwsServicecatalogConstraint#accept_language</a>.
        /// </summary>
        [<CustomOperation "accept_language">]
        member _.AcceptLanguage(state: DataAwsServicecatalogConstraintState<'Id>, value: string) : DataAwsServicecatalogConstraintState<'Id> =
            state.assignments.Add(fun config -> config.AcceptLanguage <- value)
            state : DataAwsServicecatalogConstraintState<'Id>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_constraint#description-1">DataAwsServicecatalogConstraint#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataAwsServicecatalogConstraintState<'Id>, value: string) : DataAwsServicecatalogConstraintState<'Id> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataAwsServicecatalogConstraintState<'Id>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_constraint#timeouts-1">DataAwsServicecatalogConstraint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsServicecatalogConstraintState<'Id>, value: aws.DataAwsServicecatalogConstraint.DataAwsServicecatalogConstraintTimeouts) : DataAwsServicecatalogConstraintState<'Id> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsServicecatalogConstraintState<'Id>

        member _.Run(state: DataAwsServicecatalogConstraintState<Present>) : aws.DataAwsServicecatalogConstraint.DataAwsServicecatalogConstraint =
            let config = aws.DataAwsServicecatalogConstraint.DataAwsServicecatalogConstraintConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsServicecatalogConstraint.DataAwsServicecatalogConstraint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsServicecatalogConstraint: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsServicecatalogConstraintState<_>) : aws.DataAwsServicecatalogConstraint.DataAwsServicecatalogConstraint =
            Unchecked.defaultof<aws.DataAwsServicecatalogConstraint.DataAwsServicecatalogConstraint>
