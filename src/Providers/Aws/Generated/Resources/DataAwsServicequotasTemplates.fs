namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsServicequotasTemplatesState<'Region> = { assignments: ResizeArray<aws.DataAwsServicequotasTemplates.DataAwsServicequotasTemplatesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicequotas_templates">aws_servicequotas_templates</a>.
    /// </summary>
    type DataAwsServicequotasTemplatesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsServicequotasTemplatesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicequotasTemplatesState<Missing>)

        member _.Zero(()) : DataAwsServicequotasTemplatesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicequotasTemplatesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicequotas_templates#region-1">DataAwsServicequotasTemplates#region</a>.
        /// </summary>
        [<CustomOperation "region">]
        member _.Region(state: DataAwsServicequotasTemplatesState<Missing>, value: string) : DataAwsServicequotasTemplatesState<Present> =
            state.assignments.Add(fun config -> config.Region <- value)
            ({ assignments = state.assignments } : DataAwsServicequotasTemplatesState<Present>)

        /// <summary>
        /// templates block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicequotas_templates#templates-1">DataAwsServicequotasTemplates#templates</a> Accepts: aws.IResolvable | aws.DataAwsServicequotasTemplates.DataAwsServicequotasTemplatesTemplates[]
        /// </summary>
        [<CustomOperation "templates">]
        member _.Templates(state: DataAwsServicequotasTemplatesState<'Region>, value: HashiCorp.Cdktf.IResolvable) : DataAwsServicequotasTemplatesState<'Region> =
            state.assignments.Add(fun config -> config.Templates <- value)
            state : DataAwsServicequotasTemplatesState<'Region>

        member _.Run(state: DataAwsServicequotasTemplatesState<Present>) : aws.DataAwsServicequotasTemplates.DataAwsServicequotasTemplates =
            let config = aws.DataAwsServicequotasTemplates.DataAwsServicequotasTemplatesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsServicequotasTemplates.DataAwsServicequotasTemplates(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsServicequotasTemplates: missing required arguments. Must call: region.", 9999, IsError = true)>]
        member _.Run(_: DataAwsServicequotasTemplatesState<_>) : aws.DataAwsServicequotasTemplates.DataAwsServicequotasTemplates =
            Unchecked.defaultof<aws.DataAwsServicequotasTemplates.DataAwsServicequotasTemplates>
