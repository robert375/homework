// const student={
//     name:'Robert',
//     lastName: "Rafailoski",
//     age: '27',
//     isAnActiveStudent:'true',
//     subjects:['html', 'css', 'JS'],
//     printSubjects:function(){
//         console.log(`THerse are ${this.name}  ${this.lastName}'s favorite subject`);
//         for(const subject of this.subjects){
//             console.log(subject)
//         }
//     }
// }
// student.name='sana',
// student.subjects=['mouse', 'keyboard']

// console.log(student)



// console.log(student.name)
// console.log((`${student.name} ${student.lastName}`))
// student.printSubjects();
// let trainer={
//     name:'Mirko',
//     lastName:'Mirkoski',
//     academy: 'Qinshift',
//     lecture:'JS',
//     getFullName:function(){
//         console.log(this.name, this.lastName)
//     }
// }
// trainer.age='39'
// console.log(trainer.name)
// delete trainer.lecture
// trainer.getFullName()


function Student(name, age, skills=[], isEnrolled=true){
    this.name= name
    this.age=age
    this.skills=skills
    this.isEnrolled=isEnrolled

    this.printSkills=function(){
        console.log(`{this.name}'s skills`)
        for(const skills of this.skills){
            console.log(skill)
        }
    }
}
const student2= new Student("Nekoj", "29", ["poker", 'free'], false)
console.log(student2)