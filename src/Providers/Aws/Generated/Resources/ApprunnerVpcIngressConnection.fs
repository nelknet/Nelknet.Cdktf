namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApprunnerVpcIngressConnectionState<'IngressVpcConfiguration, 'Name, 'ServiceArn> = { assignments: ResizeArray<aws.ApprunnerVpcIngressConnection.ApprunnerVpcIngressConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_vpc_ingress_connection">aws_apprunner_vpc_ingress_connection</a>.
    /// </summary>
    type ApprunnerVpcIngressConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApprunnerVpcIngressConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApprunnerVpcIngressConnectionState<Missing, Missing, Missing>)

        member _.Zero(()) : ApprunnerVpcIngressConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApprunnerVpcIngressConnectionState<Missing, Missing, Missing>)

        /// <summary>
        /// ingress_vpc_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_vpc_ingress_connection#ingress_vpc_configuration-1">ApprunnerVpcIngressConnection#ingress_vpc_configuration</a>
        /// </summary>
        [<CustomOperation "ingress_vpc_configuration">]
        member _.IngressVpcConfiguration(state: ApprunnerVpcIngressConnectionState<Missing, 'Name, 'ServiceArn>, value: aws.ApprunnerVpcIngressConnection.ApprunnerVpcIngressConnectionIngressVpcConfiguration) : ApprunnerVpcIngressConnectionState<Present, 'Name, 'ServiceArn> =
            state.assignments.Add(fun config -> config.IngressVpcConfiguration <- value)
            ({ assignments = state.assignments } : ApprunnerVpcIngressConnectionState<Present, 'Name, 'ServiceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_vpc_ingress_connection#name-1">ApprunnerVpcIngressConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApprunnerVpcIngressConnectionState<'IngressVpcConfiguration, Missing, 'ServiceArn>, value: string) : ApprunnerVpcIngressConnectionState<'IngressVpcConfiguration, Present, 'ServiceArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApprunnerVpcIngressConnectionState<'IngressVpcConfiguration, Present, 'ServiceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_vpc_ingress_connection#service_arn-1">ApprunnerVpcIngressConnection#service_arn</a>.
        /// </summary>
        [<CustomOperation "service_arn">]
        member _.ServiceArn(state: ApprunnerVpcIngressConnectionState<'IngressVpcConfiguration, 'Name, Missing>, value: string) : ApprunnerVpcIngressConnectionState<'IngressVpcConfiguration, 'Name, Present> =
            state.assignments.Add(fun config -> config.ServiceArn <- value)
            ({ assignments = state.assignments } : ApprunnerVpcIngressConnectionState<'IngressVpcConfiguration, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_vpc_ingress_connection#id-1">ApprunnerVpcIngressConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApprunnerVpcIngressConnectionState<'IngressVpcConfiguration, 'Name, 'ServiceArn>, value: string) : ApprunnerVpcIngressConnectionState<'IngressVpcConfiguration, 'Name, 'ServiceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApprunnerVpcIngressConnectionState<'IngressVpcConfiguration, 'Name, 'ServiceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_vpc_ingress_connection#tags-1">ApprunnerVpcIngressConnection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApprunnerVpcIngressConnectionState<'IngressVpcConfiguration, 'Name, 'ServiceArn>, value: seq<string * string>) : ApprunnerVpcIngressConnectionState<'IngressVpcConfiguration, 'Name, 'ServiceArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApprunnerVpcIngressConnectionState<'IngressVpcConfiguration, 'Name, 'ServiceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_vpc_ingress_connection#tags_all-1">ApprunnerVpcIngressConnection#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ApprunnerVpcIngressConnectionState<'IngressVpcConfiguration, 'Name, 'ServiceArn>, value: seq<string * string>) : ApprunnerVpcIngressConnectionState<'IngressVpcConfiguration, 'Name, 'ServiceArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ApprunnerVpcIngressConnectionState<'IngressVpcConfiguration, 'Name, 'ServiceArn>

        member _.Run(state: ApprunnerVpcIngressConnectionState<Present, Present, Present>) : aws.ApprunnerVpcIngressConnection.ApprunnerVpcIngressConnection =
            let config = aws.ApprunnerVpcIngressConnection.ApprunnerVpcIngressConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.ApprunnerVpcIngressConnection.ApprunnerVpcIngressConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apprunnerVpcIngressConnection: missing required arguments. Must call: ingress_vpc_configuration, name, service_arn.", 9999, IsError = true)>]
        member _.Run(_: ApprunnerVpcIngressConnectionState<_, _, _>) : aws.ApprunnerVpcIngressConnection.ApprunnerVpcIngressConnection =
            Unchecked.defaultof<aws.ApprunnerVpcIngressConnection.ApprunnerVpcIngressConnection>
