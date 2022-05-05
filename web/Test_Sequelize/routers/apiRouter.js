//apiRouter.js
const express =require('express')
const apiRouter = express.Router()
const  { insertEmployee, updateEmployee, getOneEmployee, getAllEmployees, deleteEmployee} = require('../controllers/controller.js')

// Get all employees
apiRouter.get('/', async (req, res, next)=>{
    try {
        const employees = await getAllEmployees()
        res.status(200).json({employees: employees})
    } catch(e) {
        console.log(e)
        res.sendStatus(500)
    }
})

apiRouter.param('employeeId', async (req, res, next, employeeId)=> {
    try{
        const employee = await getOneEmployee(employeeId)
        req.employee = employee;
        next(); // go to apiRouter.get('/:employeeId')
    } catch(e) {
        console.log(e)
        res.sendStatus(404)
    }
})

// Get an employee
apiRouter.get('/:employeeId',  (req, res, next)=>{
    res.status(200).json({employee: req.employee})
})

// Create an employee
apiRouter.post('/',  async (req, res, next)=>{
    try{
        const name = req.body.employee.name;
        const position = req.body.employee.position;
        const email = req.body.employee.email;
        const wage = req.body.employee.wage;
        console.log(name)
        if (!name || !position || !wage) {
            return res.sendStatus(400)
        }
        const employee =  await insertEmployee(name, position, email, wage).then(() => res.json({ message: 'Employee created.' }))
    } catch(e){
        console.log(e)
        res.sendStatus(400)
    }
})

// Update an employee
apiRouter.put('/:employeeId',  async (req, res, next)=>{
    try{
        const name = req.body.employee.name
        const position = req.body.employee.position
        const email = req.body.employee.email
        const wage = req.body.employee.wage
        const employeeId= req.params.employeeId

            if (!name || !position || !wage) {
                return res.sendStatus(400)
            }

        const employee =  await updateEmployee(name, position, email, wage, employeeId).then(()=>{return getOneEmployee(employeeId);})
        res.json({employee: employee});
    } catch(e){
        console.log(e)
        res.sendStatus(400)
    }
});

// Delete an employee
apiRouter.delete('/:employeeId', async (req, res, next)=>{
    try{
        const employeeId = req.params.employeeId;
        const response = await deleteEmployee(employeeId);
        return res.sendStatus(204);

    } catch(e){
        console.log(e);
    }
})

module.exports = apiRouter;