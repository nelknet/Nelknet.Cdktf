namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicecatalogTagOptionState<'Key, 'Value> = { assignments: ResizeArray<aws.ServicecatalogTagOption.ServicecatalogTagOptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_tag_option">aws_servicecatalog_tag_option</a>.
    /// </summary>
    type ServicecatalogTagOptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicecatalogTagOptionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogTagOptionState<Missing, Missing>)

        member _.Zero(()) : ServicecatalogTagOptionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogTagOptionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_tag_option#key-1">ServicecatalogTagOption#key</a>.
        /// </summary>
        [<CustomOperation "key">]
        member _.Key(state: ServicecatalogTagOptionState<Missing, 'Value>, value: string) : ServicecatalogTagOptionState<Present, 'Value> =
            state.assignments.Add(fun config -> config.Key <- value)
            ({ assignments = state.assignments } : ServicecatalogTagOptionState<Present, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_tag_option#value-1">ServicecatalogTagOption#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: ServicecatalogTagOptionState<'Key, Missing>, value: string) : ServicecatalogTagOptionState<'Key, Present> =
            state.assignments.Add(fun config -> config.Value <- value)
            ({ assignments = state.assignments } : ServicecatalogTagOptionState<'Key, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_tag_option#active-1">ServicecatalogTagOption#active</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "active">]
        member _.Active(state: ServicecatalogTagOptionState<'Key, 'Value>, value: bool) : ServicecatalogTagOptionState<'Key, 'Value> =
            state.assignments.Add(fun config -> config.Active <- value)
            state : ServicecatalogTagOptionState<'Key, 'Value>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_tag_option#active-1">ServicecatalogTagOption#active</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "active">]
        member _.Active(state: ServicecatalogTagOptionState<'Key, 'Value>, value: HashiCorp.Cdktf.IResolvable) : ServicecatalogTagOptionState<'Key, 'Value> =
            state.assignments.Add(fun config -> config.Active <- value)
            state : ServicecatalogTagOptionState<'Key, 'Value>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_tag_option#id-1">ServicecatalogTagOption#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicecatalogTagOptionState<'Key, 'Value>, value: string) : ServicecatalogTagOptionState<'Key, 'Value> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicecatalogTagOptionState<'Key, 'Value>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_tag_option#timeouts-1">ServicecatalogTagOption#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicecatalogTagOptionState<'Key, 'Value>, value: aws.ServicecatalogTagOption.ServicecatalogTagOptionTimeouts) : ServicecatalogTagOptionState<'Key, 'Value> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicecatalogTagOptionState<'Key, 'Value>

        member _.Run(state: ServicecatalogTagOptionState<Present, Present>) : aws.ServicecatalogTagOption.ServicecatalogTagOption =
            let config = aws.ServicecatalogTagOption.ServicecatalogTagOptionConfig()
            for setter in state.assignments do
                setter config
            aws.ServicecatalogTagOption.ServicecatalogTagOption(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.servicecatalogTagOption: missing required arguments. Must call: key, value.", 9999, IsError = true)>]
        member _.Run(_: ServicecatalogTagOptionState<_, _>) : aws.ServicecatalogTagOption.ServicecatalogTagOption =
            Unchecked.defaultof<aws.ServicecatalogTagOption.ServicecatalogTagOption>
