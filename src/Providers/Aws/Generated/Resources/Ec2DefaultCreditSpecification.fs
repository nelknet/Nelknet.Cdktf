namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2DefaultCreditSpecificationState<'CpuCredits, 'InstanceFamily> = { assignments: ResizeArray<aws.Ec2DefaultCreditSpecification.Ec2DefaultCreditSpecificationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_default_credit_specification">aws_ec2_default_credit_specification</a>.
    /// </summary>
    type Ec2DefaultCreditSpecificationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2DefaultCreditSpecificationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2DefaultCreditSpecificationState<Missing, Missing>)

        member _.Zero(()) : Ec2DefaultCreditSpecificationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2DefaultCreditSpecificationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_default_credit_specification#cpu_credits-1">Ec2DefaultCreditSpecification#cpu_credits</a>.
        /// </summary>
        [<CustomOperation "cpu_credits">]
        member _.CpuCredits(state: Ec2DefaultCreditSpecificationState<Missing, 'InstanceFamily>, value: string) : Ec2DefaultCreditSpecificationState<Present, 'InstanceFamily> =
            state.assignments.Add(fun config -> config.CpuCredits <- value)
            ({ assignments = state.assignments } : Ec2DefaultCreditSpecificationState<Present, 'InstanceFamily>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_default_credit_specification#instance_family-1">Ec2DefaultCreditSpecification#instance_family</a>.
        /// </summary>
        [<CustomOperation "instance_family">]
        member _.InstanceFamily(state: Ec2DefaultCreditSpecificationState<'CpuCredits, Missing>, value: string) : Ec2DefaultCreditSpecificationState<'CpuCredits, Present> =
            state.assignments.Add(fun config -> config.InstanceFamily <- value)
            ({ assignments = state.assignments } : Ec2DefaultCreditSpecificationState<'CpuCredits, Present>)

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_default_credit_specification#timeouts-1">Ec2DefaultCreditSpecification#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Ec2DefaultCreditSpecificationState<'CpuCredits, 'InstanceFamily>, value: aws.Ec2DefaultCreditSpecification.Ec2DefaultCreditSpecificationTimeouts) : Ec2DefaultCreditSpecificationState<'CpuCredits, 'InstanceFamily> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Ec2DefaultCreditSpecificationState<'CpuCredits, 'InstanceFamily>

        member _.Run(state: Ec2DefaultCreditSpecificationState<Present, Present>) : aws.Ec2DefaultCreditSpecification.Ec2DefaultCreditSpecification =
            let config = aws.Ec2DefaultCreditSpecification.Ec2DefaultCreditSpecificationConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2DefaultCreditSpecification.Ec2DefaultCreditSpecification(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2DefaultCreditSpecification: missing required arguments. Must call: cpu_credits, instance_family.", 9999, IsError = true)>]
        member _.Run(_: Ec2DefaultCreditSpecificationState<_, _>) : aws.Ec2DefaultCreditSpecification.Ec2DefaultCreditSpecification =
            Unchecked.defaultof<aws.Ec2DefaultCreditSpecification.Ec2DefaultCreditSpecification>
