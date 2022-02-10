import sys

# BuildingElement as parent class
class BuildingElement: 
    
    def __init__(self, fname):
        self.name = fname
    
    def print(self):
        print('My name is = ' + self.name)
    
# Wall as child class derived from BuildingElement
class Wall(BuildingElement): 
    
        # override the __init__()
        def __init__(self, fname, flength, fheight, fthickness):
            # call parent class constructor
            super().__init__(fname)
            self.thickness = fthickness
            self.height = fheight
            self.length = flength

        def getVolume(self): 
            return self.length*self.thickness*self.height
            
        # override the printname()
        def print(self):
                super().print()
                print('My volume is = ' + str(self.getVolume()))
                
x = Wall("Wand", 2, 0.24, 2)
x.print()